using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Produto
    {
        [Key]
        public Int32 Id { get; set; }
        public String Descricao { get; set; }
        public Double Valor { get; set; }
        public String tags { get; set; }

    }
}