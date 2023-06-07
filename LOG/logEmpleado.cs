using DAT;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG
{
    public class logEmpleado
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa

        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entEmpleado> listarEmpleado()
        {
            return datEmpleado.Instancia.listarEmpleado();
        }
        ///inserta
        public void insertarEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.insertarEmpleado(Emp);
        }

        //edita
        public void editarEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.editarEmpleado(Emp);
        }
        #endregion metodos
    }
}
