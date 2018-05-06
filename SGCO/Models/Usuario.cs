using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Usuario
    {
        [Key]
        public UInt64 UsuarioId { get; set; }

        [Required]
        public String Login { get; set; }

        [Required]
        public String Senha { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Sobrenome { get; set; }

        [Required]
        public UInt64 CPF { get; set; }

        [Required]
        public String Telefone { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required][Display(Name = "Logradouro")]
        public Logradouro LogradouroId { get; set; }
    }
}