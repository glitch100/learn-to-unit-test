using System;
using TestSandbox.App.Models;
using TestSandbox.App.Services;
using Xunit;


namespace TestSandbox.Tests.TestSandbox.App.Services.VideoServiceTests
{
    public class GetNextVideoNameTests : BaseVideoServiceTests
    {
        [Fact]
        public void GetNextVideoName_Default_DoesntReturnNull()
        {
            Assert.NotNull(_videoService.GetNextVideoName());
        }

        [Fact]
        public void GetNextVideoName_Default_DoesntReturnEmptyString()
        {
            string name = _videoService.GetNextVideoName();
            Assert.False(string.IsNullOrEmpty(name));
        }
    }
}
