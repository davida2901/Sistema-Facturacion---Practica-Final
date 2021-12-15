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
    public partial class FrmFacturar : Form
    {
        public FrmFacturar()
        {
            InitializeComponent();
        }

        private void FrmFacturar_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);

            file.Cells[0].Value = TxtCodigo.Text;
            file.Cells[1].Value = TxtNombre.Text;
            file.Cells[2].Value = TxtPrecio.Text;
            file.Cells[3].Value = TxtCantidad.Text;
            file.Cells[4].Value = (float.Parse(TxtPrecio.Text) * float.Parse(TxtCantidad.Text)).ToString();

            dgvLista.Rows.Add(file);

            TxtCodigo.Text = TxtNombre.Text = TxtPrecio.Text = TxtCantidad.Text = "";

            obtenerTotal();
        }

        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = dgvLista.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }

            TxtTotal.Text = costot.ToString();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmbProducto.SelectedIndex;
            nom = cmbProducto.SelectedItem.ToString();
            precio = cmbProducto.SelectedIndex;

            switch (cod)
            {
                case 0: TxtCodigo.Text = "01"; break;
                case 1: TxtCodigo.Text = "02"; break;
                default: TxtCodigo.Text = "03"; break;
            }

            switch (nom)
            {
                case "Zapatillas Addidas": TxtNombre.Text = "Zapatillas Addidas"; break;
                case "Gorra Polo": TxtNombre.Text = "Gorra Polo"; break;
                default: TxtNombre.Text = "Mochila Addidas"; break;
            }

            switch (precio)
            {
                case 0: TxtPrecio.Text = "150"; break;
                case 1: TxtPrecio.Text = "120"; break;
                default: TxtPrecio.Text = "140"; break;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }

        private void TxtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtDevuelta.Text = (float.Parse(TxtEfectivo.Text) - float.Parse(TxtTotal.Text)).ToString();


            }
            catch { }

            if (TxtEfectivo.Text == "")
            {
                TxtDevuelta.Text = "";
            }
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Gracias por preferirnos");

        }
    }
}
