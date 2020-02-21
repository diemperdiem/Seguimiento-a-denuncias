using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Sucursales
    {
        public byte sucursal { get; set; } //sucursal SMALLINT NOT NULL
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}