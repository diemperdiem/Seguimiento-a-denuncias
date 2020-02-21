using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Sentencia
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SentenciaId { get; set; }

        public IncidenteEnc IncidenteEnc { get; set; }

        [Required]
        public int IncidenteEncId { get; set; } //IncidenteID(FK) INTEGER NOT NULL

        [Required]
        public int Anyo { get; set; } //Anyo SMALLINT NOT NULL

        [Required]
        public int Mes { get; set; } //Mes SMALLINT NOT NULL

        [Required]
        public int UMAS { get; set; } //UMAS SMALLINT NOT NULL
    }
}