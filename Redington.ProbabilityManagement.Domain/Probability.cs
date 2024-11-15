using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redington.ProbabilityManagement.Domain
{
    public class Probability(double d)
    {
        private readonly double probability = d;
                
        public double CombinedWith(double otherProbability)
        {
            return probability * otherProbability;
        }

        public double Either(double otherProbability)
        {
            return probability + otherProbability - (probability * otherProbability);
        }
    }
}
