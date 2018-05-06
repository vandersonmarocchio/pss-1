using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SGCO.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}