using DAT;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG
{
    public class logTipoProducto
    {
        #region sigleton
        //Patron Singleton

        // Variable estática para la instancia
        private static readonly logTipoProducto _instancia = new logTipoProducto();
        //privado para evitar la instanciación directa
        public static logTipoProducto Instancia
        {
            get
            {
                return logTipoProducto._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entTipoProducto> listarTipoProducto()
        {
            return datTipoProducto.Instancia.listarTipoProducto();

        }

        public void insertarTipoProducto(entTipoProducto ti)
        {
            datTipoProducto.Instancia.insertarTipoProducto(ti);
        }

        public void editarTipoProducto(entTipoProducto ti)
        {
            datTipoProducto.Instancia.editarTipoProducto(ti);
        }

        #endregion metodos
    }
}
