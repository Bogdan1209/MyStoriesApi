using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStoriesApi.Models
{
    public class ToldStory
    {
        public int StoryId { get; set; }
        public Story Story { get; set; }
        public int FriendId { get; set; }
        public Friend Friend { get; set; }
    }
}
