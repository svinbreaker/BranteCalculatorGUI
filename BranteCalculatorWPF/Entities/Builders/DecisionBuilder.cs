using System.Linq.Expressions;

namespace BranteCalculator.Entities.Builders
{
    public class DecisionBuilder
    {
        private readonly string _name;
        private readonly List<Expression<Func<bool>>> _requirements = new List<Expression<Func<bool>>>();
        private readonly List<Expression<Action>> _consequences = new List<Expression<Action>>();
        private readonly List<Expression<Action>> _hiddenConsequences = new List<Expression<Action>>();

        public DecisionBuilder(string name)
        {
            _name = name;
        }

        public DecisionBuilder WithRequirement(Expression<Func<bool>> requirement)
        {
            _requirements.Add(requirement);
            return this;
        }

        public DecisionBuilder WithConsequence(Expression<Action> consequence)
        {
            _consequences.Add(consequence);
            return this;
        }

        public DecisionBuilder WithHiddenConsequence(Expression<Action> consequence)
        {
            _hiddenConsequences.Add(consequence);
            return this;
        }

        public Decision Build()
        {
            return new Decision(_name, _requirements, _consequences, _hiddenConsequences);
        }
    }
}
