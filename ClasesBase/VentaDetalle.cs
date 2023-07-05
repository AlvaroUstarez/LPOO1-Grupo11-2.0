using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class VentaDetalle
    {

        //Clave Primaria
        private int detalleNumero;
        public int DetalleNumero
        {
            get { return detalleNumero; }
            set { detalleNumero = value; }
        }
        
        //Clave Foranea
        private int ventaNumero;
        public int VentaNumero
        {
            get { return ventaNumero; }
            set { ventaNumero = value; }
        }

        private int prodCodigo;

        public int ProdCodigo
        {
            get { return prodCodigo; }
            set { prodCodigo = value; }
        }


        private float detallePrecio;

        public float DetallePrecio
        {
            get { return detallePrecio; }
            set { detallePrecio = value; }
        }

        private float detalleCantidad;

        public float DetalleCantidad
        {
            get { return detalleCantidad; }
            set { detalleCantidad = value; }
        }

        private float detalleTotal;

        public float DetalleTotal
        {
            get { return detalleTotal; }
            set { detalleTotal = value; }
        }
    }
}
