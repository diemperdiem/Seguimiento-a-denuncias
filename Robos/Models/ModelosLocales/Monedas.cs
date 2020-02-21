using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Monedas
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(3)]
        public string MonedaId { get; set; } //MonedaID CHAR(3) NOT NULL

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}