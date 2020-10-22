using System;
using Moq;
using PasswordResetWeb.Services;
using PasswordResetWeb.Services.FileBased;
using Xunit;
using Xunit.Abstractions;

namespace PasswordResetWeb.Tests.Services.FileBased
{
    public class PasswordCreatorTests
    {
        private ITestOutputHelper Output {get;}
        public PasswordCreatorTests(ITestOutputHelper output)
        {
            Output = output;
        }
        
        [Fact]
        public void Create_ReturnsCorrectPassword()
        {
            var expected = "Donald Duck rode his bike in the street";
            var randomizerMock = new Mock<RandomizerBase>();
            randomizerMock.Setup(x => x.GetInt(It.IsAny<int>(), It.IsAny<int>())).Returns(1);
            var passwordCreator = new PasswordCreator(randomizerMock.Object);
            var actual = passwordCreator.Create();
            Output.WriteLine($"Password: {actual}");
            Assert.Equal(actual, expected);
        }
    }
}
