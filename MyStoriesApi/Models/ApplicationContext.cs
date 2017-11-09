using Microsoft.EntityFrameworkCore;

namespace MyStoriesApi.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<ToldStory> ToldStories { get; set; }

        /*public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ToldStory>()
                .HasKey(t => new { t.FriendId, t.StoryId });

            modelBuilder.Entity<ToldStory>()
                .HasOne(f => f.Friend)
                .WithMany(t => t.ToldStories)
                .HasForeignKey(f => f.FriendId);

            modelBuilder.Entity<ToldStory>()
                .HasOne(s => s.Story)
                .WithMany(t => t.ToldStories)
                .HasForeignKey(s => s.StoryId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyStories;Trusted_Connection=True;");
        }
    }
}
