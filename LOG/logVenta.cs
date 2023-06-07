using DAT;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG
{
    public class logVenta
    {
        #region sigleton
        //Patron Singleton

        // Variable estática para la instancia
        private static readonly logVenta _instancia = new logVenta();
        //privado para evitar la instanciación directa
        public static logVenta Instancia
        {
            get
            {
                return logVenta._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entVenta> listarVenta()
        {
            return datVenta.Instancia.listarVenta();
        }
        ///inserta
        public void insertarVenta(entVenta Ven)
        {
            datVenta.Instancia.insertarVenta(Ven);
        }
        #endregion metodos
    }
}
