using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class entVenta
    {
        public int idVenta { get; set; }
        public int idComprobante { get; set; }
        public int idProducto { get; set; }
        public int Monto { get; set; }
        public DateTime fecha_hora { get; set; }
        public int idTipoPago { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }
       
    }
}
