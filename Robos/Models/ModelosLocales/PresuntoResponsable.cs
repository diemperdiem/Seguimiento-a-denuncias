using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class PresuntoResponsable
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(10)]
        public string LineItem { get; set; } //LineItem CHAR(10) NOT NULL

        public IncidenteEnc IncidenteEnc { get; set; }

        [Required]
        public int IncidenteEncId { get; set; } //IncidenteID(FK) INTEGER NOT NUL
        
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL

        [Required]
        public bool EsReincidente { get; set; } //EsReincidente BIT NOT NULL

        [Required]
        [StringLength(2)]
        public string EstatusLegalID { get; set; } //EstatusLegalID (FK) CHAR(2) NOT NULL

        [Required]
        [StringLength(50)]
        public string CarpetaRelacionadaID { get; set; }//CarpetaRelacionadaID VARCHAR(50) NOT NULL

        [Required]
        [StringLength(50)]
        public string IdentificacionID { get; set; } //IdentificacionID VARCHAR(50) NOT NULL
    }
}