using Moq;
using Redington.ProbabilityManagement.Application.Interfaces;
using Redington.ProbabilityManagement.Application.Queries;
using FluentAssertions;

namespace Redington.ProbabilityManagement.Application.Tests
{
    public class GetProbabilityQueryHandlerTests
    {
        [Fact]
        public async void Handle_ProbabilityType_CombinedIwth_Returns_ProbabilityResult()
        {
            // Arrange
            var fileManagerServiceMock = new Mock<IFileManagerService>();
            fileManagerServiceMock
                .Setup(x => x.LogProbabilityCalculationsAsync(new Models.ProbabilityCalculationLog()));

            var handler = new GetProbabilityQueryHandler(fileManagerServiceMock.Object);

            var query = new GetProbabilityQuery
            {
                ProbabilityA = 0.5, 
                ProbabilityB = 0.5, 
                ProbabilityType = Enums.ProbabilityType.CombinedWith
            };

            //Act
            var actualResult = await handler.Handle(query, CancellationToken.None);
            var expectedResult = 0.25;

            //Assert
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public async void Handle_ProbabilityType_Either_Returns_ProbabilityResult()
        {
            // Arrange
            var fileManagerServiceMock = new Mock<IFileManagerService>();
            fileManagerServiceMock
                .Setup(x => x.LogProbabilityCalculationsAsync(new Models.ProbabilityCalculationLog()));

            var handler = new GetProbabilityQueryHandler(fileManagerServiceMock.Object);

            var query = new GetProbabilityQuery
            {
                ProbabilityA = 0.5,
                ProbabilityB = 0.5,
                ProbabilityType = Enums.ProbabilityType.Either
            };

            //Act
            var actualResult = await handler.Handle(query, CancellationToken.None);
            var expectedResult = 0.75;

            //Assert
            actualResult.Should().Be(expectedResult);

        }
    }
}