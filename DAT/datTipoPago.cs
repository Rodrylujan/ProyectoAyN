using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace DAT
{
    public class datTipoPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTipoPago _instancia = new datTipoPago();
        //privado para evitar la instanciación directa
        public static datTipoPago Instancia
        {
            get
            {
                return datTipoPago._instancia;
            }
        }
        #endregion singleton

        //Listado
        public List<entTipoPago> listarTipoPago()
        {
            SqlCommand cmd = null;
            List<entTipoPago> lista = new List<entTipoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("splistarTipoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoPago tp = new entTipoPago();
                    tp.idTipoPago = Convert.ToInt32(dr["idTipoPago"]);
                    tp.NombreTP = dr["NombreTP"].ToString();
                    lista.Add(tp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        /////////////////////////InsertaTipoInmueble
        public Boolean insertarTipoPago(entTipoPago tp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarTipoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoPago", tp.idTipoPago);
                cmd.Parameters.AddWithValue("@NombreTP", tp.NombreTP);
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

        public Boolean editarTipoPago(entTipoPago tp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("speditarTipoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoPago", tp.idTipoPago);
                cmd.Parameters.AddWithValue("@NombreTP", tp.NombreTP);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }



    }
}
