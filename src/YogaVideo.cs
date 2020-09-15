using System.Collections.Generic;

namespace yoga_rest
{
    public enum VideoLengthInMinutes {
        TenMinutes = 10,
        FifteenMinutes = 15,
        TwentyMinutes = 20,
        ThirtyMinutes = 30
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
                    Url = "https://www.youtube.com/embed/uN0VAViZ9nA",
                    Name = "10 minute MOBILITY Yoga for Neck & Shoulder Relief | Sarah Beth Yoga",
                    Minutes = VideoLengthInMinutes.TenMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/CmSDHoFR4a4",
                    Name = "10 min Full Body Power Yoga Workout | Tone Yoga Flow | Sarah Beth Yoga",
                    Minutes = VideoLengthInMinutes.TenMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/6En0LPb4Hfw",
                    Name = "10 MIN ABS + YOGA - a slow and relaxed workout for super strong abs / No Equipment I Pamela Reif",
                    Minutes = VideoLengthInMinutes.TenMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/zRPQoMfs77A",
                    Name = "7-Minute Core & Low Back Strengthening Workout to Get Rid of Back Pain",
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
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/0cCYQh0czfY",
                    Name = "Yoga For Healthy Posture - Yoga Tips (14:58)",
                    Minutes = VideoLengthInMinutes.FifteenMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/RiDhzDhsQU8",
                    Name = "Yoga For Abdominal Wall | 14 Minute Core Practice | Yoga With Adriene",
                    Minutes = VideoLengthInMinutes.TwentyMinutes
                },
                new YogaVideo {
                    Url = "https://www.youtube.com/embed/2xF_teT2_V0",
                    Name = "Yoga For Low Back and Hamstrings | Yoga With Adriene (29:00)",
                    Minutes = VideoLengthInMinutes.ThirtyMinutes
                },
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
