using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    public class TrabajarVenta
    {
        private static BindingList<VentaDetalle> detallesVenta = new BindingList<VentaDetalle>();

        public static void agregar_detalle(VentaDetalle detalle)
        {
            detallesVenta.Add(detalle);
        }

        public static BindingList<VentaDetalle> obtenerDetalles()
        {
            return detallesVenta;
        }

        //Obtiene el número de venta para guardar en la bd
        public static int iniciar_venta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtener_ultimo_numero_venta_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            int numeroVenta = (int)cmd.ExecuteScalar();
            cnn.Close();

            //Devuelve el número de Venta
            return numeroVenta + 1;
        }

        public static int guardarVenta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "alta_venta_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", venta.VentaFecha);
            cmd.Parameters.AddWithValue("@ClienteId", venta.ClienteId);


            cnn.Open();
            int numeroVenta = (int)cmd.ExecuteScalar();
            cnn.Close();

            // Utiliza el número de venta como necesites
            return numeroVenta;
        }

        public static void guardarDetalle(VentaDetalle detalle)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "alta_ventadetalle_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@venta_numero", detalle.VentaNumero);
            cmd.Parameters.AddWithValue("@producto_codigo", detalle.ProdCodigo);
            cmd.Parameters.AddWithValue("@detalle_precio", detalle.DetallePrecio);
            cmd.Parameters.AddWithValue("@detalle_cantidad", detalle.DetalleCantidad);
            cmd.Parameters.AddWithValue("@detalle_total", detalle.DetalleTotal);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void agrear_venta_detalle(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "agregar_ventadetalle_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", venta.ClienteId);

            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_ventas_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_ventas_sp";
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


        //Busca Venta por id de cliente
        public static DataTable buscar_venta_cliente_sp(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_venta_cliente_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscar_venta_x_cliente_producto(int idCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_venta_x_cliente_producto";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable mostrarTablaVentaDetalle()
        {

            // Crear una conexión a la base de datos
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_ventadetalle_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            // Crear un objeto SqlDataAdapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            // Crear un objeto DataTable
            DataTable dataTable = new DataTable();

            // Llenar el DataTable con los datos de la tabla SQL
            dataAdapter.Fill(dataTable);

            return dataTable;
        }


        //Busca una Venta entre dos Fechas
        public static DataTable buscarVentaFechaSP(DateTime fechaInicio, DateTime fechaFin)
        {
            fechaFin = fechaFin.AddDays(1).AddSeconds(-1);//final del día
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_venta_fechas_sp";


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarVentaFechaProducto(DateTime fechaInicio, DateTime fechaFin)
        {
            fechaFin = fechaFin.AddDays(1).AddSeconds(-1);//Final del día
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_venta_producto_x_fechas";


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }




    }
}
