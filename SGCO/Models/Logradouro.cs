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
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public int CEP { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public String Bairro { get; set; }

        [Required]
        public Cidade Cidade { get; set; }

        public String Referencia { get; set; }

        public String Complemento { get; set; }

    }
}