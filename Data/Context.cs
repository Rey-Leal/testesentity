using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestesEntity.Models;

namespace TestesEntity.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TestesEntity.Models.Produto> Produto { get; set; } = default!;
    }
}
