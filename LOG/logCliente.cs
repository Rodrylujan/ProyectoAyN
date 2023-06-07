using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT;
using ENT;

namespace LOG
{
    public class logCliente
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa

        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> listarCliente()
        {
            return datCliente.Instancia.listarCliente();
        }
        ///inserta
        public void InsertaCliente(entCliente Cli)
        {
            datCliente.Instancia.insertarCliente(Cli);
        }


        #endregion metodos
    }
}
