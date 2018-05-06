using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Logradouro
    {
        [Key]
        public UInt32 LogradouroId { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public UInt32 Cep { get; set; }

        [Required]
        public UInt32 Numero { get; set; }

        [Required]
        public String Bairro { get; set; }

        [Required][Display(Name = "Cidade")]
        public Cidade CidadeId { get; set; }

        public String Referencia { get; set; }

        public String Complemento { get; set; }

    }
}