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
    public class datEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instanciación directa
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entEmpleado> listarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Emp = new entEmpleado();
                    Emp.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    Emp.nombreEmpleado = dr["nombreEmpleado"].ToString();
                    Emp.dni = Convert.ToInt32(dr["dni"]);
                    Emp.TipoEmpleado = dr["TipoEmpleado"].ToString();
                    lista.Add(Emp);
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

        public Boolean insertarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spinsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEmpleado", Emp.nombreEmpleado);
                cmd.Parameters.AddWithValue("@dni", Emp.dni);
                cmd.Parameters.AddWithValue("@TipoEmpleado", Emp.TipoEmpleado);
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

        public Boolean editarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("speditarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Emp.idEmpleado);
                cmd.Parameters.AddWithValue("@nombreEmpleado", Emp.nombreEmpleado);
                cmd.Parameters.AddWithValue("@dni", Emp.dni);
                cmd.Parameters.AddWithValue("@TipoEmpleado", Emp.TipoEmpleado);
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
