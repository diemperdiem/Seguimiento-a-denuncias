using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class SeguimientoLegal
    {
        public int IncidenteID { get; set; }//IncidenteID(FK) INTEGER NOT NULL
        public string LineItem { get; set; } //LineItem CHAR(10) NOT NULL
        public DateTime FechaAcuseRecibo { set; get; } //FechaAcuseRecibo DATETIME NOT NULL
        public DateTime FechaPresentacionDenuncia { set; get; } //FechaPresentacionDenuncia DATETIME NOT NULL
        public string AgenciaMP { get; set; } //AgenciaMP VARCHAR(50) NOT NULL
        public string NUCID { get; set; } //NUCID VARCHAR(50) NOT NULL
        public string NombreAgenteMP { get; set; } //NombreAgenteMP VARCHAR(50) NOT NULL
        public DateTime FechaTestigosIntegracion { get; set; } //FechaTestigosIntegracion DATETIME NOT NULL 
        public DateTime FechaTestigosReconocimiento { get; set; } //FechaTestigosReconocimiento DATETIME NOT NULL
        public DateTime FechaAudienciaInicial { get; set; } //FechaAudienciaInicial DATETIME NOT NULL
        public DateTime FechaVinculacion { get; set; } //FechaVinculacion DATETIME NOT NULL
        public string ResultadoAudienciaVinculacion { get; set; } //ResultadoAudienciaVinculacion VARCHAR(50) NOT NULL
        public string CierreInvestigacion { get; set; } //CierreInvestigacion VARCHAR(50) NOT NULL
        public DateTime FechaAudienciaIntermedia { get; set; } //FechaAudienciaIntermedia DATETIME NOT NULL
    }
}