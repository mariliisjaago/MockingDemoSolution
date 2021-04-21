using DataBaseLibrary;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace BillingLibrary.Tests
{
    public class AmountCalculatorTests
    {
        [Fact]
        public async Task CalculateTotalBillById_ShouldReturn100IfUserNameMariliis()
        {
            // Arrange

            var mockDataAccess = new Mock<IUserDataAccess>();

            mockDataAccess.Setup(x => x.IsValidForAsync)
                .Returns(true);

            mockDataAccess.Setup(x => x.GetUserNameByIdAsync(1))
                .ReturnsAsync("Mariliis");

            var sut = new AmountCalculator(mockDataAccess.Object);

            // Act
            decimal actual = await sut.CalculateTotalBillById(1);

            // Assert
            mockDataAccess.Verify(x => x.GetUserNameByIdAsync(1), Times.Once);

            Assert.Equal(100.0m, actual);

        }

    }
}
