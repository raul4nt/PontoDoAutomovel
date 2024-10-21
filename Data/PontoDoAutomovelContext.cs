using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoDoAutomovel.Models;

namespace PontoDoAutomovel.Data
{
    public class PontoDoAutomovelContext : DbContext
    {
        public PontoDoAutomovelContext (DbContextOptions<PontoDoAutomovelContext> options)
            : base(options)
        {
        }

        public DbSet<PontoDoAutomovel.Models.Carro> Carro { get; set; } = default!;
        public DbSet<PontoDoAutomovel.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<PontoDoAutomovel.Models.Nota> Nota { get; set; } = default!;
        public DbSet<PontoDoAutomovel.Models.Vendedor> Vendedor { get; set; } = default!;
    }
}
