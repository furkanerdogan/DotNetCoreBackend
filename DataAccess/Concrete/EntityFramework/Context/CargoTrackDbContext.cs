
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok.Context
{
    public class CargoTrackDbContext : DbContext

    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=FE\\SQLEXPRESS;Database=CargoTrackDb;Trusted_Connection=True;");
        //}

        public CargoTrackDbContext(DbContextOptions<CargoTrackDbContext> options) : base(options) { }
        public CargoTrackDbContext()
        {

        }

        public DbSet<User> Users { get; set; }
    
    }
}
