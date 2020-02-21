using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class TipoIncidentes
    {
        public string TipoIncidenteId { get; set; } //TipoIncidenteID CHAR(2) NOT NULL

        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL


    }
}