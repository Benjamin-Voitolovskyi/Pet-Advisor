using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class LittleKidsRule : Rule
    {
        public LittleKidsRule() { }

        public LittleKidsRule(bool hasLittleKids)
        {
            m_hasLittleKids = hasLittleKids;
        }

        public override void Run(ref string[] pets)
        {
            if (m_hasLittleKids)
                pets = pets.Where(pet => pet != "Cat" && pet != "Parrot").ToArray();
        }

        private bool m_hasLittleKids;
    }
}
