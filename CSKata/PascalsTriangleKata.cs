using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class PascalsTriangleKata
    {
        public static List<int> PascalsTriangle(int n)
        {

            // Build tiers
            List<Tier> tiers = GetTiers(n);

            // Get Result
            List<int> result = GetResult(tiers);

            return result;
        }

        private static List<int> GetResult(List<Tier> tiers)
        {
            var result = new List<int>();
            foreach (Tier tier in tiers)
            {
                foreach (int element in tier.Elements)
                {
                    result.Add(element);
                }
            }

            return result;
        }

        private static List<Tier> GetTiers(int n)
        {
            var tiers = new List<Tier>();
            for (int levenIndex = 0; levenIndex < n; levenIndex++)
            {
                var tier = new Tier(levenIndex + 1, levenIndex == 0 ? null : tiers[levenIndex - 1]);
                tiers.Add(tier);
            }

            return tiers;
        }

        class Tier
        {
            private readonly int level;

            public Tier(int level, Tier previousTier)
            {
                this.level = level;
                Elements = GenerateElements(previousTier);
            }

            private List<int> GenerateElements(Tier previousTier)
            {
                var result = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    if (i == 0 || i == level - 1)
                    {
                        result.Add(1);
                    }
                    else if (i > 0)
                    {
                        result.Add(previousTier.Elements[i - 1] + previousTier.Elements[i]);
                    }
                }

                return result;
            }

            public List<int> Elements { get; internal set; }
        }
    }

    
}
