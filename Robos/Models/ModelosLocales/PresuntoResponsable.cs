using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class PresuntoResponsable
    {
        public int IncidenteId { get; set; } //IncidenteID(FK) INTEGER NOT NUL
        public string LineItem { get; set; } //LineItem CHAR(10) NOT NULL

        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
        public byte EsReincidente { get; set; } //EsReincidente BIT NOT NULL
        public string EstatusLegalID { get; set; } //EstatusLegalID (FK) CHAR(2) NOT NULL

        [StringLength(50)]
        public string CarpetaRelacionadaID { get; set; }//CarpetaRelacionadaID VARCHAR(50) NOT NULL

        [StringLength(50)]
        public string IdentificacionID { get; set; } //IdentificacionID VARCHAR(50) NOT NULL
    }
}