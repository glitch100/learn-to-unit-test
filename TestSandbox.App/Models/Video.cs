namespace TestSandbox.App.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object[] Chunks { get; set; }
        public Video(string name)
        {
            Name = name;
        }
    }
}
