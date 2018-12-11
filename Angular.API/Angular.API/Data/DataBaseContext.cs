using Angular.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options){}
        public DbSet<Value> Values { get; set; }
        public DbSet<Users> Users { get; set; }
    }
  
}
