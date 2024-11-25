using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmVentas : Form
    {
        private int productosEnCarrito = 0;
        private readonly object bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();
                lock (bloqueo)
                {
                    productosEnCarrito++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        lblCantidadProductos.Text = productosEnCarrito.ToString();
                    });
                    Monitor.Pulse(bloqueo);
                }
                semaforo.Release();
            });
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (productosEnCarrito <= 0)
                    {
                        ActualizarRegistro("Esperando productos en el carrito...");
                        Monitor.Wait(bloqueo);
                    }

                    if (productosEnCarrito > 0)
                    {
                        productosEnCarrito--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            lblCantidadProductos.Text = productosEnCarrito.ToString();
                        });
                    }

                    ActualizarRegistro("Producto eliminado del carrito...");
                }
            });
        }
        private void ActualizarRegistro(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarRegistro(mensaje)));
                return;
            }
            TxtResultado.AppendText($" {DateTime.Now:HH:mm:ss.fff}: {mensaje}{Environment.NewLine}");
        }
    }
}
