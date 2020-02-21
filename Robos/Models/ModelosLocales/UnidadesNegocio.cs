using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class UnidadesNegocio
    {
        public int UnidadNegocioID { get; set; } //UnidadNegocioID CHAR(2) NOT NULL
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}