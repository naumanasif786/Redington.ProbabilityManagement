using Redington.ProbabilityManagement.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redington.ProbabilityManagement.Application.Models
{
    public class ProbabilityCalculationLog
    {
        public double ProbabilityA { get; set; }
        public double ProbabilityB { get; set; }
        public ProbabilityType ProbabilityType { get; set; }
        public double ProbabilityCalculationResult { get; set; }
        public DateTime LogDateTime { get; set; }
    }
}
