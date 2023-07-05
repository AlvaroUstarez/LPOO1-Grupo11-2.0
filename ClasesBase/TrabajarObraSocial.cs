using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClasesBase
{
    public class TrabajarObraSocial
    {
        /*public static void insert_obrasocial(ObraSocial obraSocial)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO ObraSocial(OS_CUIT, OS_RazonSocial, OS_Direccion, OS_Telefono) values(@oscuit,@osrazonsocial,@osdireccion,@ostelefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@oscuit", obraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@osrazonsocial", obraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@osdireccion", obraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@ostelefono", obraSocial.Os_Telefono);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }*/

        public static void insert_obrasocial(ObraSocial obraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "alta_obrasocial_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", obraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@razonSocial", obraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", obraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@telefono", obraSocial.Os_Telefono);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();

        }

        /*public static DataTable listar_obrasocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " OS_CUIT as 'CUIT',";
            cmd.CommandText += " OS_RazonSocial as 'RazonSocial',";
            cmd.CommandText += " OS_Direccion as 'Direccion',";
            cmd.CommandText += " OS_Telefono as 'Telefono'";
            cmd.CommandText += " FROM ObraSocial as OS";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }*/

        public static DataTable listar_obrasocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_obrasocial_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_obrasocial_x_razonsocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_obrasocial_x_razonsocial_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscar_obrasocial(string buscar)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscar_obrasocial_sp";
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

        public static void modificar_obrasocial_sp(string cuit, ObraSocial obraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificar_obrasocial_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);
            cmd.Parameters.AddWithValue("@razonSocial", obraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", obraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@telefono", obraSocial.Os_Telefono);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void borrar_obrasocial(string cuit)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "baja_obrasocial_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
