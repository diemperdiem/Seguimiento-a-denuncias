using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteTestigos
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Incidente Testigos Id")]
        public int IncidenteTestigoId { get; set; } //LineItem SMALLINT NOT NULL

        public IncidenteEnc IncidenteEnc { get; set; }

        [Required]
        public int IncidenteEncId { get; set; } //IncidenteID(FK) INTEGER NOT NULL

        [Required]
        [StringLength(50)]
        public string NombreTestigo { get; set; } //NombreTestigo VARCHAR(50) NOT NULL

        [Required]
        [StringLength(10)]
        public string TelefonoTestigo { get; set; } //TelefonoTestigo CHAR(10) NOT NULL
    }
}