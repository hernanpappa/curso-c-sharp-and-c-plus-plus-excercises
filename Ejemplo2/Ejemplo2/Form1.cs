using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            string login, password;
            login = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();

            if( login.Equals("UAT") && password == "informatica")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("ACCESO DENEGADO!!!");
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
