using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class IncidenteEnc
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Incidente Id (Incidente Enc)")]
        public int IncidenteId { get; set; } //IncidenteID INTEGER NOT NULL

        [Required]
        [Display(Name = "Fecha Incidente")]
        public DateTime FechaIncidente { get; set; } //FechaIncidente DATETIME NULL

        public TipoIncidentes TipoIncidete { get; set; }
        [Required]
        public string TipoIncidenteID { get; set; } //TipoIncidenteID(FK) CHAR(2) NOT NULL **Type?**

        public Sucursales Sucursales { get; set; }

        [Required]
        public byte SucursalId { get; set; } //sucursal(FK) SMALLINT NOT NULL
        public string UnidadNegocioID { get; set; } //UnidadNegocioID(FK) CHAR(2) NOT NULL
        public string CantidadDetenidos { get; set; } //CantidadDetenidos CHAR(10) NULL
        public string Notas1 { get; set; } //Notas1 CHAR(10) NULL
        public string Notas2 { get; set; } //Notas2 CHAR(10) NULL
    }
}