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
    public class datProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instanciación directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado
        public List<entProducto> listarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Inm = new entProducto();
                    Inm.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Inm.nombreProducto = dr["nombreProducto"].ToString();
                    Inm.idtipoProducto = Convert.ToInt32(dr["idtipoProducto"]);
                    Inm.descripcion = dr["descripcion"].ToString();
                    Inm.costoProducto = Convert.ToInt32(dr["costoProducto"]);
                    lista.Add(Inm);
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
        /////////////////////////InsertaProducto
        public Boolean insertarProducto(entProducto Inm)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Inm.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", Inm.nombreProducto);
                cmd.Parameters.AddWithValue("@idtipoProducto", Inm.idtipoProducto);
                cmd.Parameters.AddWithValue("@descripcion", Inm.descripcion);
                cmd.Parameters.AddWithValue("@costoProducto", Inm.costoProducto);
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


        //////////////////////////////////EditarProducto
        public Boolean editarProducto(entProducto Inm)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("speditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Inm.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", Inm.nombreProducto);
                cmd.Parameters.AddWithValue("@idtipoProducto", Inm.idtipoProducto);
                cmd.Parameters.AddWithValue("@descripcion", Inm.descripcion);
                cmd.Parameters.AddWithValue("@costoProducto", Inm.costoProducto);

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

        #endregion metodos
    }
}
