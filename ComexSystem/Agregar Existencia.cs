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
    public partial class Agregar_Existencia : Form
    {
        int cantidad;
        public Agregar_Existencia(int cantidad)
        {
            this.cantidad = cantidad;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtBC.Text.Equals("") && !txtCan.Text.Equals(""))
            {
                cantidad = cantidad + Int32.Parse(txtCan.Text);
                if (SQLCONN.UpExis(txtBC.Text, cantidad.ToString()))
                {
                    this.Close();
                    Almacen op = new Almacen();
                    op.MdiParent = ComexSystem.Menu.ActiveForm;
                    op.Show();
                }else
                {
                    MessageBox.Show("Llene el codigo de barras y agrege una cantidad");
                }
            }
        }
    }
}
