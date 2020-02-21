using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Activos
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncidenteId { get; set; } //IncidenteID (FK) INTEGER NOT NULL //preubaaaa

        [Required]
        public byte LineItem { get; set; } //LineItem SMALLINT NOT NULL **Type?**

        [Required]
        [StringLength(50)]
        string Nombre { get; set; } //Nombre VARCHAR(50) NOT NUL
    }
}