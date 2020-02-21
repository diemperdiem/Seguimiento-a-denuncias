using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robos.Models
{
    public class Perdida
    {
        public int IncidenteID { set; get; } //IncidenteID(FK) INTEGER NOT NUL
        public byte LineItem { set; get; } //LineItem SMALLINT NOT NULL
        public float Venta { set; get; } //Venta DECIMAL(18,2) NOT NULL
        public string MonedaVenta { set; get; } //MonedaVenta(FK) CHAR(3) NOT NULL
        public float Fondo { set; get; } //Fondo DECIMAL(18,2) NOT NULL
        public string MonedaFondo { set; get; } //MonedaFondo(FK) CHAR(3) NOT NULL
        public float TipoCambio { set; get; } //TipoCambio DECIMAL(10,4) NOT NULL
        public float DolarMoneyClip { set; get; } //DolarMoneyClip DECIMAL(18,2) NOT NULL
        public float MercanciasGenerales { set; get; } //MercanciasGenerales DECIMAL(18,2) NOT NULL
        public float MercanciasAjustadas { set; get; } //MercanciasAjustadas DECIMAL(18,2) NOT NULL
    }
}