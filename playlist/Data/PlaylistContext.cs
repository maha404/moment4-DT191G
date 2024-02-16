using playlist.Models;
using Microsoft.EntityFrameworkCore;

namespace playlist.Data 
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base (options) {}

        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}