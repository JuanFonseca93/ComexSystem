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
    public partial class proveedores : Form
    {
        int x = 0;
        public proveedores()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLCONN.getprov();
            habi(false);
        }

        public void habi(bool hab)
        {
            txtUbi.Enabled = hab;
            txtCor.Enabled = hab;
            txtNombre.Enabled = hab;
            txtTel.Enabled = hab;
            btnGuardar.Enabled = hab;
        }

        public void clear()
        {
            txtUbi.Text = "";
            txtCor.Text = "";
            txtNombre.Text = "";
            txtTel.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                if (!txtNombre.Text.Equals("") && !txtCor.Text.Equals("") && !txtTel.Text.Equals("") && !txtUbi.Text.Equals(""))
                {
                    if (SQLCONN.NewProv(txtNombre.Text, txtTel.Text, txtTel.Text, txtUbi.Text))
                    {
                        MessageBox.Show("Proveedor agregado");
                        dataGridView1.DataSource = SQLCONN.getprov();
                        clear();
                        habi(false);
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los campos");

                }
            }
            else
            {
                if (!txtNombre.Text.Equals("") && !txtCor.Text.Equals("") && !txtTel.Text.Equals("") && !txtUbi.Text.Equals(""))
                {
                    if (SQLCONN.UpProv(txtNombre.Text, txtTel.Text, txtCor.Text, txtUbi.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Proveedor Actualizado");
                        dataGridView1.DataSource = SQLCONN.getprov();
                        habi(false);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 0;
            habi(true);
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 1;
            habi(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtCor.Text.Equals("") && !txtTel.Text.Equals("") && !txtUbi.Text.Equals(""))
            {
                String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (SQLCONN.delprov(id))
                {
                    MessageBox.Show("Proveedor eliminado");

                    dataGridView1.DataSource = SQLCONN.getprov();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUbi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtCor.Text.Equals("") && !txtTel.Text.Equals("") && !txtUbi.Text.Equals(""))
            {
                Form2 open = new Form2(Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),txtNombre.Text);
                open.MdiParent = ComexSystem.Menu.ActiveForm;
                open.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un Proveedor");
            }
        }
    }
}
