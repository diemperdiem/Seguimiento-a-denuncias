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
        string EstatusLegalId { get; set; } //EstatusLegalID CHAR(2) NOT NULL

        [Required]
        [StringLength(50)]
        string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}