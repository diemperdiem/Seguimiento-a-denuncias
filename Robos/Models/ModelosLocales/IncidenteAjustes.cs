using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteAjustes
    {
        public int IncidenteID { get; set; } //IncidenteID(FK) INTEGER NOT NULL
        public string FolioAjuste { get; set; } //FolioAjuste VARCHAR(50) NOT NULL
    }
}