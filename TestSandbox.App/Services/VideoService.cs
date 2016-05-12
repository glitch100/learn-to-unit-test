using System;
using System.Collections.Generic;
using System.Linq;
using TestSandbox.App.Models;

namespace TestSandbox.App.Services
{
    public interface IVideoService
    {
        string GetNextVideoName();
        void ClearQueue();
        void AddToQueue(Video video);
    }

    public class VideoService : IVideoService
    {
        private Queue<Video> Videos { get; set; }
        public VideoService()
        {
            Videos = new Queue<Video>();
        }

        public string GetNextVideoName()
        {
            if (!Videos.Any())
            {
                throw new Exception("No Videos in the Queue");
            }
            return Videos.Peek().Name;
        }

        public void ClearQueue()
        {
            Videos.Clear();
        }

        public void AddToQueue(Video video)
        {
            Videos.Enqueue(video);
        }
    }
}
