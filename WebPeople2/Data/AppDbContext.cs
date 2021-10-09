using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPeople2.Models;

namespace WebPeople2.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Person> People { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
    }
}
