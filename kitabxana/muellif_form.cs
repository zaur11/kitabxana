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
    public partial class muellif_form : Form
    {
        public muellif_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnelave_et_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;
            int kitab_id = Convert.ToInt32(txtkitab_id.Text);
            Muellifler muellif = new Muellifler();
            muellif.muellif_elave_et(ad,kitab_id);
        }
    }
}
