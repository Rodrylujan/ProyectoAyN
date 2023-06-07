using DAT;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LOG
{
    public class logTipoPago
    {
        #region sigleton
        //Patron Singleton

        // Variable estática para la instancia
        private static readonly logTipoPago _instancia = new logTipoPago();
        //privado para evitar la instanciación directa
        public static logTipoPago Instancia
        {
            get
            {
                return logTipoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entTipoPago> listarTipoPago()
        {
            return datTipoPago.Instancia.listarTipoPago();

        }

        public void insertarTipoPago(entTipoPago tp)
        {
            datTipoPago.Instancia.insertarTipoPago(tp);
        }

        public void editarTipoPago(entTipoPago tp)
        {
            datTipoPago.Instancia.editarTipoPago(tp);
        }

        #endregion metodos

    }
}
