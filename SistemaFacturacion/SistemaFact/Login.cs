using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFact
{
    public partial class FrmLogin : Form
    {

        public String nombreUsuario;


        public FrmLogin()
        {
            InitializeComponent();

            nombreUsuario = this.TxtUsuario.Text;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!");
            this.TxtContra.Text = "";
            this.TxtUsuario.Text = "";
            this.Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
