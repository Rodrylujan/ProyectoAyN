using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class entPago
    {
        public int idComprobantePagos { get; set; }
        public int MontoPago { get; set; }
        public DateTime fechaPago { get; set; }
        public int idEmpleado { get; set; }
        public int idTipoPago { get; set; }
    }
}
