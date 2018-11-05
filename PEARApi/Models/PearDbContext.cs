using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PEARApi.Models
{
    public class PearDbContext: DbContext
    {
        public PearDbContext(DbContextOptions<PearDbContext> options)
            : base(options) { }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Device> Device { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<RepairStatus> RepairStatus { get; set; }

    }
}
