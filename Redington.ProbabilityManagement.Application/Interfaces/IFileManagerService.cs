using Redington.ProbabilityManagement.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redington.ProbabilityManagement.Application.Interfaces
{
    public interface IFileManagerService
    {
        Task LogProbabilityCalculationsAsync(ProbabilityCalculationLog log);
    }
}
