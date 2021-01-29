using dotnet_rpg.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        //Provide a struct to get our data at the database
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //The name of this method is the same of the table
        public DbSet<Character> Characters { get; set; }

    }
}