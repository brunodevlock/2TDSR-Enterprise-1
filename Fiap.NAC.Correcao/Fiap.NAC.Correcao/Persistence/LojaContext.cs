using Fiap.NAC.Correcao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.NAC.Correcao.Persistence
{
    public class LojaContext : DbContext
    {
        public DbSet<Venda> Vendas { get; set; }
    }
}