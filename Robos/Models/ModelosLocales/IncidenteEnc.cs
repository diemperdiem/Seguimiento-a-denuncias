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
        [Display(Name = "Incidente Enc Id")]
        public int IncidenteId { get; set; } //IncidenteID INTEGER NOT NULL

        [Required]
        [Display(Name = "Fecha Incidente")]
        public DateTime FechaIncidente { get; set; } //FechaIncidente DATETIME NULL

        public TipoIncidente TipoIncidete { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoIncidenteId { get; set; } //TipoIncidenteID(FK) CHAR(2) NOT NULL **Type?**

        public Sucursales Sucursal { get; set; }

        [Required]
        public int SucursalId { get; set; } //sucursal(FK) SMALLINT NOT NULL

        public UnidadesNegocio UnidadNegocio { get; set; }

        [Required]
        [Display(Name = "Unidad Negocio")]
        [StringLength(2)]
        public string UnidadNegocioId { get; set; } //UnidadNegocioID(FK) CHAR(2) NOT NULL

        [Required]
        [Display(Name = "Cantidad Detenidos")]
        [StringLength(10)]
        public string CantidadDetenidos { get; set; } //CantidadDetenidos CHAR(10) NULL

        [Required]
        [Display(Name = "Nota 1")]
        [StringLength(10)]
        public string Notas1 { get; set; } //Notas1 CHAR(10) NULL

        [Required]
        [Display(Name = "Nota 2")]
        [StringLength(10)]
        public string Notas2 { get; set; } //Notas2 CHAR(10) NULL
    }
}