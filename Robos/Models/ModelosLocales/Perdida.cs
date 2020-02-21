using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Perdida
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerdidaId { set; get; } //LineItem SMALLINT NOT NULL

        public IncidenteEnc IncidenteEnc { get; set; }

        [Required]
        public int IncidenteEncId { set; get; } //IncidenteID(FK) INTEGER NOT NUL

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Venta { set; get; } //Venta DECIMAL(18,2) NOT NULL

        [Required]
        [StringLength(3)]
        public string MonedaVenta { set; get; } //MonedaVenta(FK) CHAR(3) NOT NULL

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Fondo { set; get; } //Fondo DECIMAL(18,2) NOT NULL

        [Required]
        [StringLength(3)]
        public string MonedaFondo { set; get; } //MonedaFondo(FK) CHAR(3) NOT NULL

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TipoCambio { set; get; } //TipoCambio DECIMAL(10,4) NOT NULL

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DolarMoneyClip { set; get; } //DolarMoneyClip DECIMAL(18,2) NOT NULL

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MercanciasGenerales { set; get; } //MercanciasGenerales DECIMAL(18,2) NOT NULL

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MercanciasAjustadas { set; get; } //MercanciasAjustadas DECIMAL(18,2) NOT NULL
    }
}