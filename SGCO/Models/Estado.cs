using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Estado
    {
        [Key]
        public String EstadoId { get; set; }

        [Required][StringLength(2, MinimumLength = 2)]
        public String UF { get; set; }

        [Required]
        public String Nome { get; set; }
        
    }
}