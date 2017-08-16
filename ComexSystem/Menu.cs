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
    public partial class Menu : Form
    {
        int lvl;
        String Nombre;
        public Menu(int lvl, String Nombre)
        {
            this.lvl = lvl;
            this.Nombre = Nombre;
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            WindowState = FormWindowState.Maximized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void txtUsrs_Click(object sender, EventArgs e)
        {
            control_de_usuarios open = new control_de_usuarios();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Almacen open = new Almacen();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            proveedores open = new proveedores();
            open.MdiParent = this;
            open.Show();
        }
    }
}
