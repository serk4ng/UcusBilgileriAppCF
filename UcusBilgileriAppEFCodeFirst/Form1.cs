using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusBilgileriAppEFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuHavayollari_Click(object sender, EventArgs e)
        {
            frmHavayollariIslemleri frm = new frmHavayollariIslemleri();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuHavayollariListe_Click(object sender, EventArgs e)
        {
            frmHavayoluListe frm = new frmHavayoluListe();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
