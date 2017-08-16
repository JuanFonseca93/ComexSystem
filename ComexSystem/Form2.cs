using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComexSystem
{
    public partial class Form2 : Form
    {
        int ID = 0;
            String Prov = "";
        DateTime hoy = DateTime.Today;
        public Form2(int id, String Prov)
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLCONN.getped(id);
            this.ID = id;
            this.Prov = Prov;
            txtProveedor.Text = Prov;
            txtProveedor.Enabled = false;
            txtFecha.Text = hoy.ToString("d");
            txtFecha.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtProducto.Text.Equals("") && !txtCant.Text.Equals("") && !txtFecha.Text.Equals(""))
            {
                if (SQLCONN.NewPred(ID.ToString(),txtProducto.Text,txtCant.Text,txtFecha.Text))
                {
                    MessageBox.Show("Pedido Guardado");
                    dataGridView1.DataSource = SQLCONN.getped(ID);
                    txtProducto.Text = "";
                    txtCant.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }
        }
    }
}
