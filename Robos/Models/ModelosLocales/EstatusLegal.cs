using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class EstatusLegal
    {
        [Key]
        [Required]
        [StringLength(2)]
        [Display(Name = "Estatus Legal Id")]
        public string EstatusLegalId { get; set; } //EstatusLegalID CHAR(2) NOT NULL **Type?**

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}