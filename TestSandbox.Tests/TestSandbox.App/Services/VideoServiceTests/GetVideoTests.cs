using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestSandbox.Tests.TestSandbox.App.Services.VideoServiceTests
{
    public class GetVideosTests : BaseVideoServiceTests
    {
        [Fact]
        public void GetVideos_Default_DoesntReturnNull()
        {
            Assert.NotNull(_videoService.GetVideos());
        }

        [Fact]
        public void GetVideos_HasVideos_ReturnsPopulatedCollection()
        {
            PopulateVideoQueue();
            var videos = _videoService.GetVideos();
            Assert.NotEmpty(videos);
        }
    }
}
