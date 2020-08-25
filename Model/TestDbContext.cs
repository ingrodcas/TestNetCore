using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Permits> Permit { get; set; }
        public virtual DbSet<PermissionType> PermissionType { get; set; }

    }
}
