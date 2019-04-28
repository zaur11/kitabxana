using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kitabxana
{
    public partial class oxucu_form : Form
    {
        public oxucu_form()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;
            string soyad = txtsoyad.Text;
            string adres = txtadres.Text;
            int yash = Convert.ToInt32(txtyash.Text);
            Oxucular oxucu = new Oxucular();
            oxucu.oxucu_elave_et(ad,soyad,adres,yash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
