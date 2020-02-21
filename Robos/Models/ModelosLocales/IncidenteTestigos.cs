using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteTestigos
    {
        public int IncidenteID { get; set; } //IncidenteID(FK) INTEGER NOT NULL
        public int LineItem { get; set; } //LineItem SMALLINT NOT NULL
        public string NombreTestigo { get; set; } //NombreTestigo VARCHAR(50) NOT NULL
        public string TelefonoTestigo { get; set; } //TelefonoTestigo CHAR(10) NOT NULL
    }
}