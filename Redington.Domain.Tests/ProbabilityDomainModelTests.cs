using Redington.ProbabilityManagement.Domain;
using FluentAssertions;

namespace Redington.Domain.Tests
{

    public class ProbabilityDomainModelTests
    {
        private readonly double probabilityA = 0.5;
        private readonly double probabilityB = 0.5;
                
        [Fact]
        public void CombinedWithTest()
        {
            var p1 = new Probability(probabilityA);
            var actual = p1.CombinedWith(probabilityB);
            actual.Should().Be(0.25);          
        }
        [Fact]
        public void EitherTest()
        {
            var p1 = new Probability(probabilityA);
            var actual = p1.Either(probabilityB);
            actual.Should().Be(0.75);
        }
    }
}