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
    public partial class ProductosVendidosView : Form
    {
        public ProductosVendidosView()
        {
            InitializeComponent();
        }

        private void ProductosVendidosView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet.sp_ProductosVendidos' Puede moverla o quitarla según sea necesario.
            this.sp_ProductosVendidosTableAdapter.Fill(this.NorthwindDataSet.sp_ProductosVendidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
