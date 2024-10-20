using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dragos_Daria_Lab2.Models;

namespace Dragos_Daria_Lab2.Data
{
    public class Dragos_Daria_Lab2Context : DbContext
    {
        public Dragos_Daria_Lab2Context (DbContextOptions<Dragos_Daria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dragos_Daria_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Dragos_Daria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Dragos_Daria_Lab2.Models.Authors> Authors { get; set; } = default!;
    }
}
