using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class TipoIncidente
    {
        [Key]
        [Required]
        [StringLength(2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TipoIncidenteId { get; set; } //TipoIncidenteID CHAR(2) NOT NULL

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } //Nombre VARCHAR(50) NOT NULL


    }
}