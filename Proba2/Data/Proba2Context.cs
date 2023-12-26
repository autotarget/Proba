using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proba2.Models;

namespace Proba2.Data
{
    public class Proba2Context : DbContext
    {
        public Proba2Context (DbContextOptions<Proba2Context> options)
            : base(options)
        {
        }

        public DbSet<Proba2.Models.Equipment> Equipment { get; set; } = default!;
    }
}
