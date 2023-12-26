using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proba3.Models;

namespace Proba3.Data
{
    public class Proba3Context : DbContext
    {
        public Proba3Context (DbContextOptions<Proba3Context> options)
            : base(options)
        {
        }

        public DbSet<Proba3.Models.Equipment> Equipment { get; set; } = default!;
        public DbSet<Proba3.Models.Manufacturer> Manufacturer { get; set; } = default!;
        
       
    }
}
