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
            PopulateVideoQueue();
            Assert.NotNull(_videoService.GetNextVideoName());
        }

        [Fact]
        public void GetNextVideoName_Default_DoesntReturnEmptyString()
        {
            PopulateVideoQueue();
            string name = _videoService.GetNextVideoName();
            Assert.False(string.IsNullOrEmpty(name));
        }

        [Fact]
        public void GetNextVideoName_VideosDontExist_ThrowsException()
        {
            Assert.Throws<Exception>(() => _videoService.GetNextVideoName());
        }

        [Fact]
        public void GetNextVideoName_VideosExist_ReturnsKnownName()
        {
            const string expected = "Ultimate Video";
            var v = new Video(expected);

            _videoService.AddToQueue(v);

            Assert.Equal(expected, _videoService.GetNextVideoName());
        }
    }
}
