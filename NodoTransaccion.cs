using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroATM
{
    public class NodoTransaccion
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Monto { get; set; }

        public NodoTransaccion Siguiente { get; set; } // puntero al siguiente

        public override string ToString()
            => $"{Fecha:dd/MM/yyyy HH:mm} | {Descripcion} | S/. {Monto:0.00}";
    }
}
