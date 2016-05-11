using System;
using TestSandbox.App.Models;
using TestSandbox.App.Services;
using Xunit;


namespace TestSandbox.Tests.TestSandbox.App.Services.VideoServiceTests
{
    public class GetNextVideoNameTests : BaseVideoServiceTests
    {
        private VideoService _videoService;

        public GetNextVideoNameTests()
        {
            _videoService = new VideoService();
        }
    }
}
