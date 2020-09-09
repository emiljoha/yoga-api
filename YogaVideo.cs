using System.Collections.Generic;

namespace yoga_rest
{
    public enum VideoLengthInMinutes {
        TenMinutes = 10,
        FifteenMinutes = 15,
        TwentyMinutes = 20
    }

    public class YogaVideo
    {
        public string Url { get; set;}
        public VideoLengthInMinutes Minutes {get; set;}
    }

    public class YogaVideoStore
    {
        static public List<YogaVideo> AllVideos()
        {
            return new List<YogaVideo> {
                new YogaVideo {
                    Url = "url",
                    Minutes = VideoLengthInMinutes.TenMinutes
                }
            };
        }
        static public List<YogaVideo> AllMatching(VideoLengthInMinutes minutes)
        {
            return YogaVideoStore
                .AllVideos()
                .FindAll(video => video.Minutes == minutes);
        }
    }
}
