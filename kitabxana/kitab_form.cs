using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitabxana
{
    public partial class kitab_form : Form
    {
        public kitab_form()
        {
            InitializeComponent();
        }

        private void btnelave_et_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;
            int sehife = Convert.ToInt32(txtsehife.Text);
            int qiymet = Convert.ToInt32(txtqiymet.Text);
            int stok = Convert.ToInt32(txtstok.Text);
            string kateqoriya = txtkateqoriya.Text;
            Kitablar kitab = new Kitablar();
            kitab.kitab_elave_et(ad,sehife,qiymet,stok,kateqoriya);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
