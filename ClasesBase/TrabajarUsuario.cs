using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {

        public static DataTable list_roles_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_roles_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            //Llena los datos de la consulta en el DataTable
            da.Fill(dt);

            return dt;
        }


        public static void insert_usuario(Usuario user) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "alta_usuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@nombre_usuario", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contraseña", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellido", user.Usu_Apellido);
            cmd.Parameters.AddWithValue("@nombre", user.Usu_Nombre);
            cmd.Parameters.AddWithValue("@email", user.Usu_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_usuarios_sp()
        {
            //TODO:
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "listar_usuarios_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);



            //Crear el data set
            DataSet ds = new DataSet();

            //Cargar el data set con el data adapter
            da.Fill(ds);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_usuarios_sp";

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

        public static Usuario login(string nombreUsuario, string contraseña)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "validar_usuario_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Usu_ID = int.Parse(sdr["Usu_ID"].ToString());
                usuario.Usu_NombreUsuario = sdr["Usu_NombreUsuario"].ToString();
                usuario.Usu_Contraseña = sdr["Usu_Contraseña"].ToString();
                usuario.Usu_Apellido = sdr["Usu_Apellido"].ToString();
                usuario.Usu_Nombre = sdr["Usu_Nombre"].ToString();
                usuario.Usu_Email = sdr["Usu_Email"].ToString();
                usuario.Rol_Codigo = int.Parse(sdr["Rol_Codigo"].ToString());
                return usuario;
            }
            else
            {
                return null;
            }
        }
    }
}
