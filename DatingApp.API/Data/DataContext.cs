using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // A DbContext instance represents a session with the database and can be 
    // used to query and save instances of your entities. 
    // DbContext is a combination of the Unit Of Work and Repository patterns.
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}