using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    abstract class Rule
    {
        public Rule()
        {
            m_rulesToSkip = new();
        }

        public abstract void Run(ref string[] pets);

        protected virtual void SetRulesToSkip() { }

        public List<Rule> RulesToSkip => m_rulesToSkip;

        private List<Rule> m_rulesToSkip;
    }
}
