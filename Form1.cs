using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CajeroATM
{
    public partial class Form1 : Form
    {
        private readonly PilaTransacciones _pila  = new PilaTransacciones();
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryMonto(out decimal monto)
        {
            var txt = txtMonto.Text.Trim();
            return decimal.TryParse(txt, NumberStyles.Number, CultureInfo.GetCultureInfo("es-PE"), out monto)
                || decimal.TryParse(txt, NumberStyles.Number, CultureInfo.InvariantCulture, out monto);
        }

        private void RefrescarLista(int top = 10)
        {
            lstHistorial.Items.Clear();
            foreach (var linea in _pila.VerUltimas(top))
                lstHistorial.Items.Add(linea);
            decimal saldoActual = _pila.CalcularSaldo();
            lblSaldo.Text =$"Saldo Disponible: S/. {saldoActual:0.00}";
        }
        private void LimpiarEntrada()
        {

            txtDetalle.Clear();
            cmbTipo.SelectedIndex = 0;
            txtMonto.Text = "50";
            cmbTipo.Focus();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                string tipo = cmbTipo.SelectedItem.ToString();

                string detalle = txtDetalle.Text.Trim();

                if (!TryMonto(out var monto) || monto <= 0)
                    throw new Exception("Monto inválido. Debe ser mayor a 0.");

                string descripcionFinal = string.IsNullOrWhiteSpace(detalle) ? tipo : $"{tipo} | {detalle}";

                _pila.Push(descripcionFinal, monto);

                RefrescarLista((int)numTop.Value);
                LimpiarEntrada();

                MessageBox.Show("¡Transacción registrada exitosamente!",
                                "Registro Exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerUltimas_Click(object sender, EventArgs e)
        {
            RefrescarLista((int)numTop.Value);
        }

        private void btnCargarMock_Click(object sender, EventArgs e)
        {
            _pila.CargarMock();
            RefrescarLista((int)numTop.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Depósito");
            cmbTipo.Items.Add("Retiro");
            cmbTipo.Items.Add("Pago");
            cmbTipo.Items.Add("Transferencia Enviada");
            cmbTipo.SelectedIndex = 0;

            _pila.CargarMock();
            RefrescarLista((int)numTop.Value);
        }

        private void Anular_Click(object sender, EventArgs e)
        {
            try
            {
                _pila.Pop();
                RefrescarLista((int)numTop.Value);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btnAnularSeleccionado_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VERIFICAR SI ALGO ESTÁ SELECCIONADO
                if (lstHistorial.SelectedItem == null)
                {
                    throw new Exception("Por favor, seleccione una transacción de la lista para anular.");
                }

                // 2. OBTENER LOS DATOS DE LA TRANSACCIÓN SELECCIONADA
                string transaccionString = lstHistorial.SelectedItem.ToString();

                // 3. PARSEAR (SEPARAR) EL STRING PARA ENTENDERLO
                string[] partes = transaccionString.Split(new[] { " | " }, StringSplitOptions.None);

                if (partes.Length < 3)
                {
                    throw new Exception("La transacción seleccionada no tiene el formato esperado.");
                }

                string tipoActual = partes[1].Trim();
                string detalleOriginal = "";
                if (partes.Length > 3) // Si tiene 4+ partes, la 3ra (índice 2) es el detalle
                {
                    detalleOriginal = partes[2].Trim();
                }

                string montoString = partes[partes.Length - 1]
                                        .Replace("S/.", "")
                                        .Trim();

                if (!decimal.TryParse(montoString, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal monto))
                {
                    if (!decimal.TryParse(montoString, NumberStyles.Number, CultureInfo.GetCultureInfo("es-PE"), out monto))
                    {
                        throw new Exception($"No se pudo leer el monto: '{montoString}'");
                    }
                }

                if (tipoActual.ToLower().Contains("anulación") || tipoActual.ToLower().Contains("extorno"))
                {
                    throw new Exception("No se puede anular una transacción que ya es una anulación.");
                }

                string nuevoTipo;
                string nuevoDetalleBase;

                if (tipoActual.Contains("Depósito"))
                {
                    nuevoTipo = "Retiro";
                    nuevoDetalleBase = $"Anulación de {tipoActual}";
                }
                else
                {
                    nuevoTipo = "Depósito";
                    nuevoDetalleBase = $"Extorno de {tipoActual}";
                }

                string nuevoDetalleFinal;
                if (!string.IsNullOrEmpty(detalleOriginal))
                {
                    nuevoDetalleFinal = $"{nuevoDetalleBase} ({detalleOriginal})";
                }
                else
                {
                    nuevoDetalleFinal = nuevoDetalleBase;
                }

                string descripcionFinal = $"{nuevoTipo} | {nuevoDetalleFinal}";

                _pila.Push(descripcionFinal, monto);

                RefrescarLista((int)numTop.Value);

                string transaccionOriginalDesc = tipoActual;
                if (!string.IsNullOrEmpty(detalleOriginal))
                {
                    transaccionOriginalDesc += $" ({detalleOriginal})";
                }

                string mensajeExito = $"¡Transacción anulada exitosamente!\n\n" +
                                      $"Operación Original: {transaccionOriginalDesc}\n" +
                                      $"Monto: S/. {monto:0.00}\n\n" +
                                      $"Corrección Aplicada: Se agregó un '{nuevoTipo}' para ajustar el saldo.";

                MessageBox.Show(mensajeExito,
                                "Anulación Exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
