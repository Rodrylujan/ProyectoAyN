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
    public class datPago
    {
        #region sigleton
        // Variable estática para la instancia
        private static readonly datPago _instancia = new datPago();
        //privado para evitar la instanciación directa
        public static datPago Instancia
        {
            get
            {
                return datPago._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entPago> listarPagos()
        {
            SqlCommand cmd = null;
            List<entPago> lista = new List<entPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistarPagos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPago Pag = new entPago();
                    Pag.idComprobantePagos = Convert.ToInt32(dr["idComprobantePagos"]);
                    Pag.MontoPago = Convert.ToInt32(dr["MontoPago"]);
                    Pag.fechaPago = Convert.ToDateTime(dr["fechaPago"]);
                    Pag.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    Pag.idTipoPago = Convert.ToInt32(dr["idTipoPago"]);
                    lista.Add(Pag);
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

        public Boolean insertarPago(entPago Pag)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idComprobantePagos", Pag.idComprobantePagos);
                cmd.Parameters.AddWithValue("@MontoPago", Pag.MontoPago);
                cmd.Parameters.AddWithValue("@fechaPago", Pag.fechaPago);
                cmd.Parameters.AddWithValue("@idEmpleado", Pag.idEmpleado);
                cmd.Parameters.AddWithValue("@idTipoPago", Pag.idTipoPago);
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
