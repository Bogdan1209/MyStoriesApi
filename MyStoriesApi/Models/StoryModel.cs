﻿using System.Collections.Generic;

namespace MyStoriesApi.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ToldStory> ToldStories { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
