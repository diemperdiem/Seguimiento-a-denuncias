using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class PresuntoResponsable
    {
        public int IncidenteID { get; set; } //IncidenteID(FK) INTEGER NOT NUL
        public string LineItem { get; set; } //LineItem CHAR(10) NOT NULL
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
        public byte EsReincidente { get; set; } //EsReincidente BIT NOT NULL
        public string EstatusLegalID { get; set; } //EstatusLegalID (FK) CHAR(2) NOT NULL
        public string CarpetaRelacionadaID { get; set; }//CarpetaRelacionadaID VARCHAR(50) NOT NULL
        public string IdentificacionID { get; set; } //IdentificacionID VARCHAR(50) NOT NULL
    }
}