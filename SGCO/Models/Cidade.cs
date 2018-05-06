using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Cidade
    {
        [Key]
        public UInt32 CidadeId { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required][Display(Name = "Estado")]
        public Estado EstadoId { get; set; }
    }
}