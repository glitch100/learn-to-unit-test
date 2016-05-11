using System;
using System.Collections.Generic;
using System.Linq;
using TestSandbox.App.Models;

namespace TestSandbox.App.Services
{
    public interface IVideoService
    {
    }

    public class VideoService : IVideoService
    {
        private Queue<Video> Videos { get; set; }
        public VideoService()
        {
            Videos = new Queue<Video>();
        }
    }
}
