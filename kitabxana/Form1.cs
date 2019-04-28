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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        connectionstring cc = new connectionstring();

        private void oxucuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            oxucu_form of = new oxucu_form();
            of.ShowDialog();

        }

        private void muellifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muellif_form muellif = new muellif_form();
            muellif.ShowDialog();
        }

        private void kitabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitab_form kitab = new kitab_form();
            kitab.ShowDialog();
        }

        private void btnqebul_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Kitab adina ve ya Muellife gore filtr verin!");
            }
            else
            {
                SqlConnection con = new SqlConnection(cc.connection);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (radioButton1.Checked == true)
                {
                    string melumatlari_getir = "select k.id,k.ad,k.kateqoriya,k.qiymet, k.sehife, k.stok,m.ad from dbo.kitablarr k left join dbo.muelliflerr m on k.id = m.kitab_id where k.ad like  '" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(melumatlari_getir, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[1].Value = dr[1].ToString();
                            dataGridView1.Rows[i].Cells[2].Value = dr[2].ToString();
                            dataGridView1.Rows[i].Cells[3].Value = dr[3].ToString();
                            dataGridView1.Rows[i].Cells[4].Value = dr[4].ToString();
                            dataGridView1.Rows[i].Cells[5].Value = dr[5].ToString();
                            dataGridView1.Rows[i].Cells[6].Value = dr[6].ToString();
                            i++;
                        }

                    }
                }
                if (radioButton2.Checked == true)
                {
                    string melumatlari_getir = "select k.id,k.ad,k.kateqoriya,k.qiymet, k.sehife, k.stok,m.ad from dbo.kitablarr k left join dbo.muelliflerr m on k.id = m.kitab_id where m.ad like  '" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(melumatlari_getir, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    if (dr.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {

                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[1].Value = dr[1].ToString();
                            dataGridView1.Rows[i].Cells[2].Value = dr[2].ToString();
                            dataGridView1.Rows[i].Cells[3].Value = dr[3].ToString();
                            dataGridView1.Rows[i].Cells[4].Value = dr[4].ToString();
                            dataGridView1.Rows[i].Cells[5].Value = dr[5].ToString();
                            dataGridView1.Rows[i].Cells[6].Value = dr[6].ToString();
                            i++;
                        }

                    }
                }
            }

            
           
            
        
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cc.connection);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string melumatlari_getir = "select * from dbo.oxucularr";
            SqlCommand cmd = new SqlCommand(melumatlari_getir, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmboxucu.Items.Add(dr[1].ToString());

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            string oxucu = "";
            try
            {
                 oxucu = cmboxucu.SelectedItem.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Oxucu secilmeyib");
            }
            
            string kitab_ad = txtkitab_adi.Text;
            string kateqoriya = txtkateqoriya.Text;
            int qiymet = Convert.ToInt32(txtqiymet.Text);
            int sehife = Convert.ToInt32(txtsehife.Text);
            string muellif = txtmuellif.Text;

            SqlConnection con = new SqlConnection(cc.connection);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string connectionstring = "INSERT INTO DBO.icare (oxucu,kitab_adi,kateqoriya,qiymet,sehife,muellif) values (@params1,@params2,@params3,@params4,@params5,@params6)";
            SqlCommand cmd = new SqlCommand(connectionstring,con);
            cmd.Parameters.AddWithValue("@params1", oxucu);
            cmd.Parameters.AddWithValue("@params2", kitab_ad);
            cmd.Parameters.AddWithValue("@params3", kateqoriya);
            cmd.Parameters.AddWithValue("@params4", qiymet);
            cmd.Parameters.AddWithValue("@params5", sehife);
            cmd.Parameters.AddWithValue("@params6", muellif);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from dbo.icare", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                }

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow item = this.dataGridView1.Rows[e.RowIndex];

                txtkitab_adi.Text = item.Cells[1].Value.ToString();
                txtkateqoriya.Text = item.Cells[2].Value.ToString();
                txtqiymet.Text = item.Cells[3].Value.ToString();
                txtsehife.Text = item.Cells[4].Value.ToString();
                txtstok.Text = item.Cells[5].Value.ToString();
                txtmuellif.Text = item.Cells[6].Value.ToString();
            }
            
            
        }
    }
}
