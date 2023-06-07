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
    public class datTipoProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTipoProducto _instancia = new datTipoProducto();
        //privado para evitar la instanciación directa
        public static datTipoProducto Instancia
        {
            get
            {
                return datTipoProducto._instancia;
            }
        }
        #endregion singleton

        //Listado
        public List<entTipoProducto> listarTipoProducto()
        {
            SqlCommand cmd = null;
            List<entTipoProducto> lista = new List<entTipoProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("splistarTipoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoProducto ti = new entTipoProducto();
                    ti.idtipoProducto = Convert.ToInt32(dr["idtipoProducto"]);
                    ti.nombreTipoProducto = dr["nombreTipoProducto"].ToString();
                    ti.descripcionTipoProducto = dr["descripcionTipoProducto"].ToString();
                    lista.Add(ti);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        /////////////////////////InsertaTipoProducto
        public Boolean insertarTipoProducto(entTipoProducto ti)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarTipoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreTipoProducto", ti.nombreTipoProducto);
                cmd.Parameters.AddWithValue("@descripcionTipoProducto", ti.descripcionTipoProducto);
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

        public Boolean editarTipoProducto(entTipoProducto ti)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("speditarTipoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtipoProducto", ti.idtipoProducto);
                cmd.Parameters.AddWithValue("@nombreTipoProducto", ti.nombreTipoProducto);
                cmd.Parameters.AddWithValue("@descripcionTipoProducto", ti.descripcionTipoProducto);
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
