using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteEnc
    {
        public int IncidenteID { get; set; } //IncidenteID INTEGER NOT NULL
        public DateTime FechaIncidente { get; set; } //FechaIncidente DATETIME NULL
        public string TipoIncidenteID { get; set; } //TipoIncidenteID(FK) CHAR(2) NOT NULL
        public byte sucursal { get; set; } //sucursal(FK) SMALLINT NOT NULL
        public string UnidadNegocioID { get; set; } //UnidadNegocioID(FK) CHAR(2) NOT NULL
        public string CantidadDetenidos { get; set; } //CantidadDetenidos CHAR(10) NULL
        public string Notas1 { get; set; } //Notas1 CHAR(10) NULL
        public string Notas2 { get; set; } //Notas2 CHAR(10) NULL
    }
}