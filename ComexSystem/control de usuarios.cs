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
    public partial class control_de_usuarios : Form
    {
        int x;
        public control_de_usuarios()
        {
            
            InitializeComponent();
            habilitar(false);
            DGVUsr.DataSource = SQLCONN.getuser();
            btnBT.Enabled = false;
        }

        public void habilitar(bool hab)
        {
            txtNombre.Enabled = hab;
            txtPss.Enabled = hab;
            txtUsr.Enabled = hab;
            cbxRango.Enabled = hab;
            btnGuardar.Enabled = hab;
            
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtUsr.Text = "";
            txtPss.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            habilitar(true);
            x = 0;
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals(""))
            {
                habilitar(true);
                x = 1;
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario");

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (x==0)
            {
                if(SQLCONN.NewUser(txtNombre.Text,txtUsr.Text,txtPss.Text,cbxRango.SelectedIndex + 1))
                {
                    MessageBox.Show("Usuario creado exitosamente");
                    DGVUsr.DataSource = SQLCONN.getuser();
                    habilitar(false);
                    limpiar();
                }
            }else
            {
                if (SQLCONN.updUser(Int32.Parse(DGVUsr.CurrentRow.Cells[0].Value.ToString()),txtNombre.Text,txtUsr.Text,txtPss.Text,cbxRango.SelectedIndex + 1))
                {
                    MessageBox.Show("Usuario actualizado");
                    DGVUsr.DataSource = SQLCONN.getuser();
                    habilitar(false);
                    limpiar();
                }
            }
        }

        private void DGVUsr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = DGVUsr.CurrentRow.Cells[4].Value.ToString();
            txtUsr.Text = DGVUsr.CurrentRow.Cells[1].Value.ToString();
            txtPss.Text = DGVUsr.CurrentRow.Cells[2].Value.ToString();
            cbxRango.SelectedIndex = Int32.Parse(DGVUsr.CurrentRow.Cells[3].Value.ToString()) - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVUsr.DataSource = SQLCONN.filtuser(txtSh.Text);
            btnBT.Enabled = true;
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            DGVUsr.DataSource = SQLCONN.getuser();
            btnBT.Enabled = false;
            txtSh.Text = "";
        }
    }
}
