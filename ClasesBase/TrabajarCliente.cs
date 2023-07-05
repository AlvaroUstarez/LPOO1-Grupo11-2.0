using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        public static void insert_cliente(Cliente client)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "alta_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", client.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", client.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", client.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", client.Cli_Direccion);
            cmd.Parameters.AddWithValue("@os_cuit", client.OS_CUIT);
            cmd.Parameters.AddWithValue("@nro_carnet", client.Cli_NroCarnet);

            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void baja_cliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "baja_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", cliente.Cli_ID);

            conn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable list_clientes_sp()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_clientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_clientes_apellido_sp()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_clientes_apellido_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_clientes_ventas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_clientes_ventas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable search_clientes(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_clientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@buscar", "%" + sPattern + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificar_Cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificar_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", cliente.Cli_ID);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.OS_CUIT);
            cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
