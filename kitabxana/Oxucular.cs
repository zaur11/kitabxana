using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kitabxana
{
    class Oxucular
    {
        public int oxucu_id { get; set; }
        public string oxucu_ad { get; set; }
        public string oxucu_soyad { get; set; }
        public string oxucu_adress { get; set; }
        public int oxucu_yash { get; set; }
        connectionstring cc = new connectionstring();

        public void oxucu_elave_et(string _ad,string _soyad, string _adress, int _yash)
        {
            oxucu_ad = _ad;
            oxucu_soyad = _soyad;
            oxucu_adress = _adress;
            oxucu_yash = _yash;
            SqlConnection con = new SqlConnection(cc.connection);
            if (con.State!= System.Data.ConnectionState.Open)
            {
                con.Open();
            }
                
            
            string oxucu_elave = "INSERT INTO dbo.oxucularr (ad,soyad,adres,yash) values (@param1,@param2,@param3,@param4)";
            SqlCommand cmd = new SqlCommand(oxucu_elave);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@param1", oxucu_ad);
            cmd.Parameters.AddWithValue("@param2", oxucu_soyad);
            cmd.Parameters.AddWithValue("@param3", oxucu_adress);
            cmd.Parameters.AddWithValue("@param4", oxucu_yash);
            cmd.ExecuteNonQuery();
         
            con.Close();
        }

    }
}
