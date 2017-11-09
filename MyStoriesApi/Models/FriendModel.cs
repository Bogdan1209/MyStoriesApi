using System.Collections.Generic;


namespace MyStoriesApi.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToldStory> ToldStories { get; set; }
    }
}
