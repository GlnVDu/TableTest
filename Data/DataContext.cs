using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace TableTest1.Data
{
    internal class DataContext:DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Author {  get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder) ;
            optionsBuilder.UseSqlServer("Server=DESKTOP-RN7F3DC;Database=Bible;TrustServerCertificate=True;");
        }
    }
}
