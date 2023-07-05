using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {

        private int prod_Codigo;

        public int Prod_Codigo
        {
            get { return prod_Codigo; }
            set { prod_Codigo = value; }
        }
        private string prod_Categoria;

        public string Prod_Categoria
        {
            get { return prod_Categoria; }
            set { prod_Categoria = value; }
        }
        private string prod_Descripcion;

        public string Prod_Descripcion
        {
            get { return prod_Descripcion; }
            set { prod_Descripcion = value; }
        }
        private double prod_Precio;

        public double Prod_Precio
        {
            get { return prod_Precio; }
            set { prod_Precio = value; }
        }
        
        
    }
}
