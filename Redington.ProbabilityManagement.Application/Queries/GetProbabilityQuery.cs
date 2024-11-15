using MediatR;
using Redington.ProbabilityManagement.Application.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Redington.ProbabilityManagement.Application.Queries
{
    public class GetProbabilityQuery: IRequest<double> 
    {
        [Range(0,1, ErrorMessage = "Value must be between 0 and 1")]
        public double ProbabilityA { get; set; }
        [Range(0, 1, ErrorMessage = "Value must be between 0 and 1")]
        public double ProbabilityB { get; set; }
        [Required]
        public ProbabilityType ProbabilityType { get; set; }

    }
}
