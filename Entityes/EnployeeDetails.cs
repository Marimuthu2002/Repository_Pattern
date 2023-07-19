using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityes
{
    public class EnployeeDetails: DbContext
    {
        public EnployeeDetails(DbContextOptions<EnployeeDetails> options):base(options)
        {
                
        }
        public DbSet<DbModel> Employee { get; set; }
        public DbSet<PostDbModel> Employees { get; set; }

    }
}
