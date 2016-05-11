using System;
using TestSandbox.App.Models;
using TestSandbox.App.Services;

namespace TestSandbox.Tests.TestSandbox.App.Services.VideoServiceTests
{
    public class BaseVideoServiceTests : IDisposable
    {
        protected VideoService _videoService;

        public BaseVideoServiceTests()
        {
            _videoService = new VideoService();
        }

        public void Dispose()
        {
            _videoService.ClearQueue();
        }

        protected void PopulateVideoQueue()
        {
            _videoService.AddToQueue(new Video("First"));
            _videoService.AddToQueue(new Video("Second"));
            _videoService.AddToQueue(new Video("Third"));
        }
    }
}
