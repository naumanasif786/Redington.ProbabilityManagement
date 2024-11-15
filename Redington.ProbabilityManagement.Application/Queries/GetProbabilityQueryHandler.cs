using MediatR;
using Redington.ProbabilityManagement.Application.Extensions;
using Redington.ProbabilityManagement.Application.Interfaces;
using Redington.ProbabilityManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Redington.ProbabilityManagement.Application.Queries
{
    public class GetProbabilityQueryHandler(IFileManagerService fileManagerService) : IRequestHandler<GetProbabilityQuery, double>
    {
        private readonly IFileManagerService _fileManagerService = fileManagerService;
        public async Task<double> Handle(GetProbabilityQuery request, CancellationToken cancellationToken)
        {
            var probability = new Probability(request.ProbabilityA);
            var calculatedProbabilityValue = request.ProbabilityType switch
            {
                Enums.ProbabilityType.CombinedWith => probability.CombinedWith(request.ProbabilityB),
                Enums.ProbabilityType.Either => probability.Either(request.ProbabilityB),
                _ => probability.CombinedWith(request.ProbabilityB),
            };

            var log = request.ToProbabilityCalculationLog(calculatedProbabilityValue);
            await _fileManagerService.LogProbabilityCalculationsAsync(log);
            return calculatedProbabilityValue;
        }
    }
}
