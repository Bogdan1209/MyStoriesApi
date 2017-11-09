using System.Collections.Generic;

namespace MyStoriesApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Story> Stories { get; set; }
        public List<Friend> Friends { get; set; }
    }
}
