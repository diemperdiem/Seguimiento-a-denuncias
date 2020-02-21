using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class FristResponse
    {
        [Key]
        [Required]
        [Display(Name = "Incidente Id (First Response)")]
        public int IncidenteId { set; get; } //IncidenteID (FK) INTEGER NOT NULL

        [Required]
        [Display(Name = "Line Item")]
        public byte LineItem { set; get; } //LineItem SMALLINT NOT NULL **Type?**

        [Required]
        [StringLength(50)]
        public string Distrito { set; get; } //Distrito VARCHAR(50) NOT NULL

        [Required]
        [Display(Name = "Fecha Boton Panico")]
        public DateTime FechaBotonPanico { set; get; } //FechaBotonPanico DATETIME NOT NULL

        [Required]
        [Display(Name = "Arribo Policia")]
        public DateTime ArriboPolicia { set; get; } //ArriboPolicia DATETIME NOT NULL

        [Required]
        [Display(Name = "Tiempo Respuesta")]
        public byte TiempoRespuesta { set; get; } //TiempoRespuesta SMALLINT NOT NULL **Type?**

        [Required]
        [Display(Name = "Incidente 911")]
        [StringLength(50)]
        public string Incidente911ID { set; get; } //Incidente911ID VARCHAR(50) NOT NULL

        [Required]
        public string IPHID { set; get; } //IPHID VARCHAR(50) NOT NULL

        [Required]
        [Display(Name = "Notas Internas")]
        public string NotasInternas { set; get; } //NotasInternas VARCHAR(max) NOT NULL
    }
}