using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Produto
    {
        public Int32 Codigo { get; set; }
        public String Descricao { get; set; }
        public Double Valor { get; set; }
        public String tags { get; set; }

    }
}