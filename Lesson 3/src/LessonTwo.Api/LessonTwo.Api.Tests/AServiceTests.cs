using LessonTwo.Core.App.Services;
using Xunit;

namespace LessonTwo.Api.Tests
{
    public class AServiceTests
    {
        [Fact]
        public void FieldsAreNotNull()
        {
            // Arrange
            AService aService = new AService();

            // Act
            string aServiceGuid = aService.GetService();

            // Assert
            Assert.NotNull(aServiceGuid);
        }

        [Fact]
        public void FieldsAreNotEmpty()
        {
            // Arrange
            AService aService = new AService();

            // Act
            string aServiceGuid = aService.GetService();

            // Assert
            Assert.NotEmpty(aServiceGuid);
        }        
    }
}
