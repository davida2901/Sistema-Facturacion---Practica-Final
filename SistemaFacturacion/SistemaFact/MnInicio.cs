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
    public partial class MnInicio : Form
    {
        public MnInicio()
        {
            InitializeComponent();

            

            mostrarMenu("ADMIN");



        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnInicio_Load(object sender, EventArgs e)
        {
            
        }

        public void mostrarLogin()
        {
            FrmLogin login = new FrmLogin();

            login.MdiParent = this;

            login.StartPosition = FormStartPosition.CenterParent;

            login.Show();
        }

        public void mostrarMenu(String usuario)
        {
            Conexion con = new Conexion();

            List<string> opciones = con.consultarPermisos(usuario);
            
            foreach (String opc in opciones)
            {
                foreach (System.Windows.Forms.ToolStripMenuItem obj in MnPrincipal.Items)
                {
                    if (obj.ToString() == opc)
                    {
                        obj.Enabled = true;
                    }
                        
                }
            }
        }



        public void mostrarOpciones()   
        {
            List<string> opciones = new List<string>();

            opciones.Add("AYUDA");
            opciones.Add("INICIO");
            opciones.Add("CONSULTAS");
            opciones.Add("REPORTES");
            opciones.Add("ADMINISTRACION");
            opciones.Add("CONFIGURACION");
            opciones.Add("MANTENIMIENTOS");
            opciones.Add("FACTURAR");

            foreach (String opc in opciones)
            {
                foreach (System.Windows.Forms.ToolStripMenuItem obj in MnPrincipal.Items)
                {
                    if (obj.ToString() == opc)
                    {
                        obj.Enabled = true;
                    }
                }
            }

        }


        public void mostrarFacturar()
        {
            FrmFacturar facturar = new FrmFacturar();

            facturar.MdiParent = this;

            facturar.StartPosition = FormStartPosition.CenterParent;

            facturar.Show();

        }

        public void mostrarAdministracion()
        {
            FrmAdministracion administrar = new FrmAdministracion();

            administrar.MdiParent = this;

            administrar.StartPosition = FormStartPosition.CenterParent;

            administrar.Show();

        }

        public void mostrarReportes()
        {
            FrmReportes reportes = new FrmReportes();

            reportes.MdiParent = this;

            reportes.StartPosition = FormStartPosition.CenterParent;

            reportes.Show();

        }



        private void FACTURAR_Click(object sender, EventArgs e)
        {
            mostrarFacturar();
        }

        private void ADMINISTRACION_Click(object sender, EventArgs e)
        {
            mostrarAdministracion();
        }

        private void REPORTES_Click(object sender, EventArgs e)
        {
            mostrarReportes();
        }

        private void CONSULTA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacto: davidadon29@gmail.com     telefono: 800-000-0000");
        }

        private void AYUDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacto: davidadon29@gmail.com     telefono: 800-000-0000");
        }

        private void INICIO_Click(object sender, EventArgs e)
        {
            
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            mostrarLogin();
        }

        private void CONFIGURACION_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Mantenimiento");
        }

        private void MANTENIMIENTO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Mantenimiento");
        }
    }
}
