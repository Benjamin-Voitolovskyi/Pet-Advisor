using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class LifeStyleRule : Rule
    {
        public LifeStyleRule() { }

        public LifeStyleRule(bool isActiveLifestyle)
        {
            m_isActiveLifestyle = isActiveLifestyle;
        }

        public override void Run(ref string[] pets)
        {
            if (m_isActiveLifestyle)
            {
                pets = new string[] { "Dog" };
            }
            else
            {
                pets = pets.Where(pet => pet != "Dog").ToArray();
            }
            SetRulesToSkip();
        }

        protected override void SetRulesToSkip()
        {
            if (m_isActiveLifestyle)
            {
                RulesToSkip.Add(new AllergyRule());
                RulesToSkip.Add(new NoFreeTimeRule());
                RulesToSkip.Add(new LittleKidsRule());
                RulesToSkip.Add(new LittleSpaceRule());
                RulesToSkip.Add(new SizeRule());
            }   
            else
            {
                RulesToSkip.Add(new LittleSpaceRule());
            }
        }

        private bool m_isActiveLifestyle;
    }
}
