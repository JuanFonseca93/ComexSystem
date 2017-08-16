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
    public partial class Form1 : Form
    {
        DataTable ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = SQLCONN.checkUser(txtUsr.Text, txtPss.Text);
            DataRow dr = ds.Rows[0];
            Menu op = new Menu(Int32.Parse(dr["nivel"].ToString()),dr["Nombre"].ToString());
            op.Show();
            this.Hide();
        }
    }
}
