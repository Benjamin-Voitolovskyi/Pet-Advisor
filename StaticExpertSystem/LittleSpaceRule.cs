using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class LittleSpaceRule : Rule
    {
        public LittleSpaceRule() { }

        public LittleSpaceRule(bool hasLittleSpace)
        {
            m_hasLittleSpace = hasLittleSpace;
        }

        public override void Run(ref string[] pets)
        {
            if (m_hasLittleSpace)
                pets = pets.Where(pet => pet != "Dog").ToArray();
        }

        private bool m_hasLittleSpace;
    }
}
