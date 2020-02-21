using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteAjustes
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Folio ajuste")]
        [StringLength(50)]
        public string FolioAjuste { get; set; } //FolioAjuste VARCHAR(50) NOT NULL

        public IncidenteEnc IncidenteEnc { get; set; }

        [Required]
        [Display(Name = "Incidente Enc Id")]
        public int IncidenteAjustesId { get; set; } //IncidenteID(FK) INTEGER NOT NULL

        
    }
}