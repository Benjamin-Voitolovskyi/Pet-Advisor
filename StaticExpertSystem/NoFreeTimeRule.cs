using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class NoFreeTimeRule : Rule
    {
        public NoFreeTimeRule() { }

        public NoFreeTimeRule(bool noFreeTime)
        {
            m_noFreeTime = noFreeTime;
        }

        public override void Run(ref string[] pets)
        {
            if (!m_noFreeTime)
                return;

            pets = pets.Where(pet => pet != "Dog" && pet != "Cat" && pet != "Parrot").ToArray();
            SetRulesToSkip();
        }

        protected override void SetRulesToSkip()
        {
            RulesToSkip.Add(new LittleKidsRule());
            RulesToSkip.Add(new LittleSpaceRule());
        }

        private bool m_noFreeTime;
    }
}
