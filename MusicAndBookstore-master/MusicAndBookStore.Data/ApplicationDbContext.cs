using Microsoft.EntityFrameworkCore;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.Data
{
    public class ApplicationDbContext : DbContext
    { 
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MusicAlbum> MusicAlbums { get; set;}
        public DbSet<Product> Products { get; set; }
    }
}
