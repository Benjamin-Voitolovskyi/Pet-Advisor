using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class GoalRule : Rule
    {
        public GoalRule(string goal)
        {
            m_goal = goal;
        }
        public override void Run(ref string[] pets)
        {
            switch(m_goal)
            {
                case "Guard":
                    pets = pets.Where(pet => pet == "Dog").ToArray();
                    SetRulesToSkip();
                    break;
                case "Mouse Hunter":
                    pets = pets.Where(pet => pet == "Cat").ToArray();
                    SetRulesToSkip();
                    break;
                case "For Pleasure":
                    break;
                default:
                    throw new Exception("Unexpected goal");
            }
        }

        protected override void SetRulesToSkip()
        {
            RulesToSkip.Add(new LifeStyleRule());
            RulesToSkip.Add(new AllergyRule());
            RulesToSkip.Add(new NoFreeTimeRule());
            RulesToSkip.Add(new LittleKidsRule());
            RulesToSkip.Add(new LittleSpaceRule());
            RulesToSkip.Add(new SizeRule());
        }

        private string m_goal;
    }
}
