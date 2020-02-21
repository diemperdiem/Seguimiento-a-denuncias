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
        [Display(Name = "Activos Id")]
        public int ActivosId { get; set; } //LineItem SMALLINT NOT NULL **Type?**

        public IncidenteEnc IncidenteEnc { get; set; }
        
        [Required]
        [Display(Name = "Incidente Enc Id")]
        public int IncidenteEncId { get; set; } //IncidenteID (FK) INTEGER NOT NULL //preubaaaa

        [Required]
        [StringLength(50)]
        string Nombre { get; set; } //Nombre VARCHAR(50) NOT NUL
    }
}