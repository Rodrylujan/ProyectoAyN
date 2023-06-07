using DAT;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG
{
    public class logPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPago _instancia = new logPago();
        //privado para evitar la instanciación directa

        public static logPago Instancia
        {
            get
            {
                return logPago._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entPago> listarPagos()
        {
            return datPago.Instancia.listarPagos();
        }
        ///inserta
        public void insertarPago(entPago Pag)
        {
            datPago.Instancia.insertarPago(Pag);
        }
        #endregion metodos


    }
}
