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
    public partial class Almacen : Form
    {
        int x = 0;
        public Almacen()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLCONN.getprod();
            habi(false);
        }

        public void habi(bool hab)
        {
            txtBC.Enabled = hab;
            txtExistencia.Enabled = hab;
            txtNombre.Enabled = hab;
            txtPrecio.Enabled = hab;
            btnGuardar.Enabled = hab;
        }

        public void clear()
        {
            txtBC.Text = "";
            txtExistencia.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 0;
            habi(true);
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                if (!txtNombre.Text.Equals("") && !txtExistencia.Text.Equals("") && !txtPrecio.Text.Equals("") && !txtBC.Text.Equals(""))
                {
                    if (SQLCONN.NewProd(txtNombre.Text, txtPrecio.Text, txtPrecio.Text, txtBC.Text))
                    {
                        MessageBox.Show("Producto agregado");
                        dataGridView1.DataSource = SQLCONN.getprod();
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
                if (!txtNombre.Text.Equals("") && !txtExistencia.Text.Equals("") && !txtPrecio.Text.Equals("") && !txtBC.Text.Equals(""))
                {
                    if (SQLCONN.UpProd(txtNombre.Text,txtPrecio.Text,txtExistencia.Text,txtBC.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Producto Actualizado");
                        dataGridView1.DataSource = SQLCONN.getprod();
                        habi(false);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 1;
            habi(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtExistencia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agregar_Existencia op = new Agregar_Existencia(Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
            op.MdiParent = ComexSystem.Menu.ActiveForm;
            op.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtExistencia.Text.Equals("") && !txtPrecio.Text.Equals("") && !txtBC.Text.Equals(""))
            {
                String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (SQLCONN.delprod(id))
                {
                    MessageBox.Show("Producto eliminado");

                    dataGridView1.DataSource = SQLCONN.getprod();

                }
            }else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }
    }
}
