using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class entCliente
    {
        public int idCliente { get; set; }
        public string Nombre { get; set; }
        public int dni { get; set; }
        public int telefono { get; set; }
        public DateTime fecRegCliente { get; set; }
        public Boolean estCliente { get; set; }
    }
}
