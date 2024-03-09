using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class AllergyRule : Rule
    {
        public AllergyRule() { }

        public AllergyRule(bool hasAllergy)
        {
            m_hasAllergy = hasAllergy;
        }
        public override void Run(ref string[] pets)
        {
            if (!m_hasAllergy)
                return;

            pets = pets.Where(pet => pet != "Dog" && pet != "Cat" && pet != "Parrot").ToArray();
            SetRulesToSkip();
        }

        protected override void SetRulesToSkip()
        {
            RulesToSkip.Add(new NoFreeTimeRule());
            RulesToSkip.Add(new LittleKidsRule());
            RulesToSkip.Add(new LittleSpaceRule());
        }

        private bool m_hasAllergy;
    }
}
