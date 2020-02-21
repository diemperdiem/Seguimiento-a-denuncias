using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class FristResponse
    {
        public int IncidenteId { set; get; } //IncidenteID (FK) INTEGER NOT NULL
        public byte LineItem { set; get; } //LineItem SMALLINT NOT NULL
        public string Distrito { set; get; } //Distrito VARCHAR(50) NOT NULL
        public DateTime FechaBotonPanico { set; get; } //FechaBotonPanico DATETIME NOT NULL
        public DateTime ArriboPolicia { set; get; } //ArriboPolicia DATETIME NOT NULL
        public byte TiempoRespuesta { set; get; } //TiempoRespuesta SMALLINT NOT NULL
        public string Incidente911ID { set; get; } //Incidente911ID VARCHAR(50) NOT NULL
        public string IPHID { set; get; } //IPHID VARCHAR(50) NOT NULL
        public string NotasInternas { set; get; } //NotasInternas VARCHAR(max ) NOT NULL
    }
}