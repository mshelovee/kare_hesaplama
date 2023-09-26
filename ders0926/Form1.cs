using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders0926
{
    public partial class frmKare : Form
    {
        public frmKare()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            int sonuc = sayi * sayi;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
