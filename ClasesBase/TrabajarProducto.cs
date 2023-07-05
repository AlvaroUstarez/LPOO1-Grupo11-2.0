using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static void insert_product(Producto product)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "alta_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prodcategoria", product.Prod_Categoria);
            cmd.Parameters.AddWithValue("@prodescripcion", product.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@prodprecio", product.Prod_Precio);
            cmd.Parameters.AddWithValue("@baja", false);

            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable listar_product()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_producto_x_categoria()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_x_categoria_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_producto_x_descripcion()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_x_descripcion_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_producto_x_defecto()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_x_defecto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_producto(int codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_producto_codigo_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        /*Buscar productos por Código, Descripción y Categoría.*/
        public static DataTable buscarProductoDescripcion(string buscar)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscar_producto_descripcion_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificarProductoSP(int id, Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificar_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Prod_Precio);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void darDeBajaProducto(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "baja_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@baja", true);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
