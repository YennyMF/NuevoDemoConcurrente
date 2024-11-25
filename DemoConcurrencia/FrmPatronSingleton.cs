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
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instanace;
            cadenaConexion.cadenaConexion = TxtCadenaDeConexion.Text;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instanace;
            LblCadenaDeConexionRecuperada .Text = cadenaConexion.cadenaConexion;
        }
    }
}
