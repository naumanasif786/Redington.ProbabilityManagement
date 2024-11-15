using Redington.ProbabilityManagement.Application.Models;
using Redington.ProbabilityManagement.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redington.ProbabilityManagement.Application.Extensions
{
    //We could also use AutoMapper rather than writing mapper ourselves
    public static class ModelExtensions
    {
        public static ProbabilityCalculationLog ToProbabilityCalculationLog(this GetProbabilityQuery query, double result)
        {
            return new ProbabilityCalculationLog
            {
                LogDateTime = DateTime.Now,
                ProbabilityA = query.ProbabilityA,
                ProbabilityB = query.ProbabilityB,
                ProbabilityType = query.ProbabilityType,
                ProbabilityCalculationResult = result
            };
        }
    }
}
