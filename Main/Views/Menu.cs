
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            var inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();
        }



        private void btn_productosVendidos_Click(object sender, EventArgs e)
        {
            var productosVendidos = new ProductosVendidosView();
            productosVendidos.ShowDialog();
        }
    }
}
