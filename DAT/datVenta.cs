using ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    public class datVenta
    {
        #region sigleton
        // Variable estática para la instancia
        private static readonly datVenta _instancia = new datVenta();
        //privado para evitar la instanciación directa
        public static datVenta Instancia
        {
            get
            {
                return datVenta._instancia;
            }
        }
        #endregion singleton
        #region metodos

        public List<entVenta> listarVenta()
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVenta Ven = new entVenta();
                    Ven.idVenta = Convert.ToInt32(dr["idVenta"]);
                    Ven.idComprobante = Convert.ToInt32(dr["idComprobante"]);
                    Ven.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Ven.Monto = Convert.ToInt32(dr["Monto"]);
                    Ven.fecha_hora = Convert.ToDateTime(dr["fecha_hora"]);
                    Ven.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Ven.idTipoPago = Convert.ToInt32(dr["idTipoPago"]);
                    Ven.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    lista.Add(Ven);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean insertarVenta(entVenta Ven)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", Ven.idVenta);
                cmd.Parameters.AddWithValue("@idComprobante", Ven.idVenta);
                cmd.Parameters.AddWithValue("@idProducto", Ven.idProducto);
                cmd.Parameters.AddWithValue("@Monto", Ven.Monto);
                cmd.Parameters.AddWithValue("@fecha_hora", Ven.fecha_hora);
                cmd.Parameters.AddWithValue("@idCliente", Ven.idCliente);
                cmd.Parameters.AddWithValue("@idTipoPago", Ven.idTipoPago);
                cmd.Parameters.AddWithValue("@idEmpleado", Ven.idEmpleado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        #endregion metodos
    }
}
