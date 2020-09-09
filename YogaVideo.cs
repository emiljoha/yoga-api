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
        public string Name {get; set;}
        public VideoLengthInMinutes Minutes {get; set;}
    }

    public class YogaVideoStore
    {
        static public List<YogaVideo> AllVideos()
        {
            return new List<YogaVideo> {
                new YogaVideo {
                    Url ="https://www.youtube.com/embed/uN0VAViZ9nA",
                    Name = "10 minute MOBILITY Yoga for Neck & Shoulder Relief | Sarah Beth Yoga",
                    Minutes = VideoLengthInMinutes.TenMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/fBNJt2CbF5s",
                    Name = "15 min Power Yoga Workout (level 1) BEACH BOD | Sarah Beth Yoga",
                    Minutes = VideoLengthInMinutes.FifteenMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/p1UxGHu9TVE",
                    Name = "20 minute Power Yoga for Strength | Arm Balances: Crow & Hurdler's Pose",
                    Minutes = VideoLengthInMinutes.TwentyMinutes
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
