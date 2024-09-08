using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoykoyYapanlaraDestek.v2.Mvc.Models;

namespace BoykoyYapanlaraDestek.v2.Mvc.Data
{
    public class BoykoyYapanlaraDestekv2MvcContext : DbContext
    {
        public BoykoyYapanlaraDestekv2MvcContext (DbContextOptions<BoykoyYapanlaraDestekv2MvcContext> options)
            : base(options)
        {
        }

        public DbSet<BoykoyYapanlaraDestek.v2.Mvc.Models.Duyuru> Duyuru { get; set; } = default!;
        public DbSet<BoykoyYapanlaraDestek.v2.Mvc.Models.Marka> Marka { get; set; } = default!;
        public DbSet<BoykoyYapanlaraDestek.v2.Mvc.Models.Adres> Adres { get; set; } = default!;
    }
}
