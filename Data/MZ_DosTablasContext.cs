using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MZ_DosTablas.Models;

namespace MZ_DosTablas.Data
{
    public class MZ_DosTablasContext : DbContext
    {
        public MZ_DosTablasContext (DbContextOptions<MZ_DosTablasContext> options)
            : base(options)
        {
        }

        public DbSet<MZ_DosTablas.Models.Burger> Burger { get; set; } = default!;

        public DbSet<MZ_DosTablas.Models.Promo>? Promo { get; set; }
    }
}
