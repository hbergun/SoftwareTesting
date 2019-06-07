using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        public string ReadVideoTitle()
        {
            var str = File.ReadAllText("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error Parsing The Video";
            return video.Title;
        }
        public string GetUnprocessedVideoAsCsv()
        {
            var videoIds = new List<int>();
            return "";
        }
    }
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Processed { get; set; }
    }
}
