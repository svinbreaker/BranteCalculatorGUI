using BranteCalculatorWPF;
using BranteCalculatorWPF.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace BranteCalculator.Entities.Events
{
    public class Event : LocalizibleObject
    {
        private bool? _isAvailable;
        
        public bool IsVariableTime { get; }
        private List<Expression<Func<bool>>> VisibleRequirements { get; set; } = new List<Expression<Func<bool>>>();
        private List<Expression<Func<bool>>> HiddenRequirements { get; set; } = new List<Expression<Func<bool>>>();
        private List<Expression<Func<bool>>> Requirements { get => VisibleRequirements.Concat(HiddenRequirements).ToList(); }
        public List<Decision> Decisions { get; set; } = new List<Decision>();
        public bool HasPassed { get; set; }

        public Decision? SelectedDecision { get => Decisions.Where(d => d.IsChecked).FirstOrDefault(); }

        public Event(string name) : base(name)
        {
            Name = name;

            _settings.LocaleChanged += OnLocaleChanged;
        }

        public Event(string name, bool isVariableTime, List<Expression<Func<bool>>> visibleRequirements, List<Expression<Func<bool>>> hiddenRequirements, List<Decision> decisions) : base(name)
        {
            Name = name;
            IsVariableTime = isVariableTime;
            if (visibleRequirements.Count > 0)
            {
                VisibleRequirements = visibleRequirements;
            }
            if (hiddenRequirements.Count > 0)
            {
                HiddenRequirements = hiddenRequirements;
            }
            if (decisions.Count > 0)
            {
                Decisions = decisions;
            }
            HasPassed = false;
        }
        
        public bool IsAvalaible
        {
            get
            {
                if (HasPassed == false)
                {
                    _isAvailable = null;
                }

                if (_isAvailable == null)
                {
                    _isAvailable = true;
                    if (Requirements.Count > 0)
                    {
                        foreach (var requirement in Requirements)
                        {

                            var compiledRequirement = requirement.Compile();
                            if (!compiledRequirement())
                            {
                               _isAvailable = false;
                            }
                        }
                    }
                }
                return _isAvailable.Value;
            }
        }

        public string RequirementsText
        {
            get
            {
                if (VisibleRequirements == null || VisibleRequirements.Count == 0)
                    return string.Empty;

                string result = string.Join(", ", VisibleRequirements.Select(expr => ExpressionTool.ConvertExpressionToText(expr.Body)));
                result = result.Replace("(", "");
                result = result.Replace(")", "");
                return "(" + result + ")";
            }
        }

        protected override void OnLocaleChanged(object? sender, EventArgs e) 
        {
            OnPropertyChanged(nameof(LocalizedName));
            OnPropertyChanged(nameof(RequirementsText));
        }

        public static bool operator ==(Event a, Event b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Name == b.Name && ReferenceEquals(a.Requirements, b.Requirements) && ReferenceEquals(a.Decisions, b.Decisions);
        }

        public static bool operator !=(Event a, Event b)
        {
            if (ReferenceEquals(a, b))
            {
                return false;
            }

            if (a is null || b is null)
            {
                return true;
            }

            return a.Name != b.Name && !ReferenceEquals(a.Requirements, b.Requirements) || ReferenceEquals(a.Decisions, b.Decisions);
        }
    }
}
