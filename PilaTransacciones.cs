using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroATM
{
    public class PilaTransacciones
    {
        private NodoTransaccion _tope;
        private decimal _saldoInicial = 1000.00m;
        public bool EstaVacia => _tope == null;

        public void Push(string descripcion, decimal monto)
        {
            var nuevo = new NodoTransaccion
            {
                Descripcion = descripcion,
                Monto = monto,
                Siguiente = _tope
            };
            _tope = nuevo;
        }
        // Recorre del tope hacia abajo (más reciente primero)
        public IEnumerable<string> VerUltimas(int cantidad = 10)
        {
            var aux = _tope;
            int n = 0;
            while (aux != null && n < cantidad)
            {
                yield return aux.ToString();
                aux = aux.Siguiente;
                n++;
            }
        }
        // Datos de prueba (opcional)
        public void CargarMock()
        {
            Push("Depósito | Saldo inicial", 100);
            Push("Retiro | Cajero Centro", 40);
            Push("Transferencia Enviada | Pago Alquiler", 200);
            Push("Pago | Servicio de Luz", 65);
            Push("Depósito | Abono Quincena", 150);
        }
        
        public void Pop()
        {
            if (EstaVacia)
                throw new Exception("No se puede anular. El historial está vacío.");
            _tope = _tope.Siguiente;    
        }
        public decimal CalcularSaldo()
        {
            decimal saldo = _saldoInicial;
            var aux = _tope;
            while (aux != null)
            {
             
                if (aux.Descripcion.StartsWith("Depósito"))
                {
                    saldo += aux.Monto;
                }
                else
                {
                    saldo -=aux.Monto;
                }
                aux = aux.Siguiente;
            }
            return saldo;
        }
    }
}
