using DAT;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton

        ///listado <summary>
        /// listado
        /// </summary>
        /// <returns></returns>

        public List<entProducto> listarProducto()
        {
            return datProducto.Instancia.listarProducto();
        }
        ///inserta
        public void insertarProducto(entProducto Inm)
        {
            datProducto.Instancia.insertarProducto(Inm);
        }

        //edita
        public void editarProducto(entProducto Inm)
        {
            datProducto.Instancia.editarProducto(Inm);
        }
    }
}
