using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteTestigos
    {
        public int IncidenteId { get; set; } //IncidenteID(FK) INTEGER NOT NULL


        public int LineItem { get; set; } //LineItem SMALLINT NOT NULL

        [StringLength(50)]
        public string NombreTestigo { get; set; } //NombreTestigo VARCHAR(50) NOT NULL


        public string TelefonoTestigo { get; set; } //TelefonoTestigo CHAR(10) NOT NULL
    }
}