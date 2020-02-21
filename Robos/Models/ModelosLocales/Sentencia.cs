using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Sentencia
    {
        public int IncidenteID { get; set; } //IncidenteID(FK) INTEGER NOT NULL
        public byte Anyo { get; set; } //Anyo SMALLINT NOT NULL
        public byte Mes { get; set; } //Mes SMALLINT NOT NULL
        public byte UMAS { get; set; } //UMAS SMALLINT NOT NULL
    }
}