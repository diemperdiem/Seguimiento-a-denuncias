using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Sucursales
    {
        public byte SucursalId { get; set; } //sucursal SMALLINT NOT NULL

        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}