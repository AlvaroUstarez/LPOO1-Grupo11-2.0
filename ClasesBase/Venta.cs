using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;

namespace ClasesBase
{
    public class Venta
    {
        private int ventaNumero;
        public int VentaNumero
        {
            get { return ventaNumero; }
            set { ventaNumero = value; }
        }

        private DateTime ventaFecha;
        public DateTime VentaFecha
        {
            get { return ventaFecha; }
            set { ventaFecha = value; }
        }

        private int clienteId;
        public int ClienteId

        {
            get { return clienteId; }
            set { clienteId = value; }
        }

        private List<VentaDetalle> ventaDetalle;
        public List<VentaDetalle> VentaDetalle
        {
            get { return ventaDetalle; }
            set { ventaDetalle = value; }
        }
    }
}
