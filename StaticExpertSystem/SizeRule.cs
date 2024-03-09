using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class SizeRule : Rule
    {
        public SizeRule() { }

        public SizeRule(string size)
        {
            m_size = size;
        }

        public override void Run(ref string[] pets)
        {
            switch(m_size)
            {
                case "Large":
                    pets = pets.Where(pet => pet == "Dog" || pet == "Parrot" || pet == "Cat").ToArray();
                    break;
                case "Medium":
                    // They all are suitable
                    break;
                case "Small":
                    pets = pets.Where(pet => pet == "Rodent" || pet == "Parrot" || pet == "Fish").ToArray();
                    break;
                default:
                    throw new Exception("Unexpected size");
            }
        }

        private string m_size;
    }
}
