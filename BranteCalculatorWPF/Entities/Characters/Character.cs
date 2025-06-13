using BranteCalculator.Entities.Enums;
using BranteCalculator.Entities.Stats;
using BranteCalculatorWPF.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranteCalculator.Entities.Characters
{
    public class Character : LocalizibleObject
    {

        private string _name;
        private Stat _relations;
        private Status? _status;

        public Stat Relations
        {
            get => _relations;
            set
            {
                _relations = value;
                OnPropertyChanged(nameof(Relations));
            }
        }
        public Status? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        } 
        public Character(string name, int relations) : base(name)
        {
            Name = name;
            _relations = new Relations(relations);
            Status = null;
        }

        public void SetName(string name) 
        {
            Name = name;
        }

        public static Character operator +(Character a, int b)
        {
            a.Relations.Value += b;
            return a;
        }


        public static Character operator -(Character a, int b)
        {
            a.Relations.Value -= b;
            return a;
        }

        public static bool operator >(Character a, int b)
        {
            return a.Relations.Value > b;
        }

        public static bool operator <(Character a, int b)
        {
            return a.Relations.Value < b;
        }

        public static bool operator >=(Character a, int b)
        {
            return a.Relations.Value >= b;
        }

        public static bool operator <=(Character a, int b)
        {
            return a.Relations.Value <= b;
        }

        public static bool operator ==(Character a, Status b)
        {
            return a.Status == b;
        }

        public static bool operator !=(Character a, Status b)
        {
            return a.Status != b;
        }

        public void Add(int a)
        {
            Relations.Value += a;
        }

        public void Set(Status? flag)
        {
            Status = flag;
        }
    }
}
