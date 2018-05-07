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
        public int Id { get; set; }

        [Required]
        public String Descricao { get; set; }

        [Required]
        public Double Valor { get; set; }

        public String Tag { get; set; }

    }
}