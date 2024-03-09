using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class RuleRunner
    {
        public static string[] Run(List<Rule> rules)
        {
            var pets = Constants.pets;

            for (int idx = 0; idx < rules.Count; ++idx)
            {
                rules[idx].Run(ref pets);
                var rulesToSkip = rules[idx].RulesToSkip;

                foreach (var ruleToSkip in rulesToSkip)
                {
                    int idx2 = idx + 1;

                    while (idx2 < rules.Count)
                    {
                        if (ruleToSkip.GetType() == rules[idx2].GetType())
                        {
                            rules.RemoveAt(idx2);
                            break;
                        }
                        else
                        {
                            ++idx2;
                        }
                    }
                }
            }

            return pets;
        }
    }
}
