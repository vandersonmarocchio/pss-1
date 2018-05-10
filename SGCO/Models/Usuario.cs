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
        public int Id { get; set; }

        [Required]
        public String Login { get; set; }

        [Required]
        public String Senha { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Sobrenome { get; set; }

        [Required]
        public long CPF { get; set; }

        [Required]
        public String Telefone { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [Required]
        public Logradouro Logradouro { get; set; }
    } 
}