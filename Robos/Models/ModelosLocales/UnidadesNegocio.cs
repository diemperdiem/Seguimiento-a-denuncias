using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class UnidadesNegocio
    {
        public int UnidadNegocioId { get; set; } //UnidadNegocioID CHAR(2) NOT NULL **Type?**

        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL
    }
}