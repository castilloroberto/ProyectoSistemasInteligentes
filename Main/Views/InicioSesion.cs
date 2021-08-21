using Main.Database;
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
    public partial class InicioSesion : Form
    {
        Consultas consultas = new Consultas();
        bool check = false;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            var parametros = new List<Parametro>() {
            
            new Parametro("@FirstName",txt_user.Text),
            new Parametro("@Password",txt_clave.Text)
            
            };


            DataTable res = consultas.Procedimiento("sp_authEmployee",parametros);

            if (res.Rows.Count == 1)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {

                //MessageBox.Show($"Bienvenido {res.Rows[0].Field<string>("Firstname")} ","Datos Correctos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show("Nombre de usuario o Contraseña Incorrectos ","Datos Incorrectos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_clave.Clear();
                txt_user.Clear();
                txt_user.Focus();
            
            }
        }

        private void checkBox_verClave_CheckedChanged(object sender, EventArgs e)
        {

            check = !check;
            if (check)
            {
                txt_clave.PasswordChar = '\0';
            }
            else
            {
                txt_clave.PasswordChar = '*';

            }
        }
    }
}
