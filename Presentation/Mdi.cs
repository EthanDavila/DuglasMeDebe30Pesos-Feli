using Core.Poco;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Mdi : Form
    {
        public List<Product> Productos;

        public Mdi()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.Productos = Productos;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
