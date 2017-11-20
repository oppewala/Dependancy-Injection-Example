using DependancyInjectionExample.Models;
using Microsoft.EntityFrameworkCore;

namespace DependancyInjectionExample.Data
{
    public class ValuesContext : DbContext
    {
        public ValuesContext(DbContextOptions<ValuesContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}
