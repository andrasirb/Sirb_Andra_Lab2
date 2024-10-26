using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sirb_Andra_Lab2.Models;

namespace Sirb_Andra_Lab2.Data
{
    public class Sirb_Andra_Lab2Context : DbContext
    {
        public Sirb_Andra_Lab2Context (DbContextOptions<Sirb_Andra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sirb_Andra_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sirb_Andra_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
