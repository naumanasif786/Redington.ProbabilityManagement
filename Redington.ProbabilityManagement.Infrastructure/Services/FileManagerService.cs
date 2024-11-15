using Redington.ProbabilityManagement.Application.Interfaces;
using Redington.ProbabilityManagement.Application.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Redington.ProbabilityManagement.Infrastructure.Services
{
    public class FileManagerService : IFileManagerService
    {
        public async Task LogProbabilityCalculationsAsync(ProbabilityCalculationLog log) 
        {
            var filePath = "probabilityCalculationLog.txt";
            
            var contents = new StringBuilder();
            contents.Append($"Log Date Time: {log.LogDateTime}");
            contents.Append($"\r\n Formula: {log.ProbabilityType}");
            contents.Append($"\r\n Probability A: {log.ProbabilityA}");
            contents.Append($"\r\n Probability B: {log.ProbabilityB}");
            contents.Append($"\r\n Result: {log.ProbabilityCalculationResult}");

            await using var file = new StreamWriter(filePath); 
            await file.WriteAsync(contents.ToString());
        }
    }
}
