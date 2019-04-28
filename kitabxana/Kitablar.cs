using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kitabxana
{
    class Kitablar
    {
        public int kitab_id { get; set; }
        public string kitab_ad { get; set; }
        public int kitab_sehife { get; set; }
        public int kitab_qiymet { get; set; }
        public int kitab_stok { get; set; }
        public Muellifler muellif { get; set; }
        public string kateqoriya { get; set; }


        connectionstring cc = new connectionstring();

        public void kitab_elave_et(string _ad, int _sehife, int _qiymet, int _stok, string _kateqoriya)
        {
            kitab_ad = _ad;
            kitab_sehife = _sehife;
            kitab_qiymet = _qiymet;
            kitab_stok = _stok;
            kateqoriya = _kateqoriya;
            SqlConnection con = new SqlConnection(cc.connection);
            
                con.Open();
          
            
            string kitab_elave = "INSERT INTO dbo.kitablarr (ad,sehife,qiymet,stok,kateqoriya) values (@params1,@params2,@params3,@params4,@params5)";
            SqlCommand cmd = new SqlCommand(kitab_elave);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@params1",kitab_ad);
            cmd.Parameters.AddWithValue("@params2",kitab_sehife);
            cmd.Parameters.AddWithValue("@params3",kitab_qiymet);
            cmd.Parameters.AddWithValue("@params4",kitab_stok);
            cmd.Parameters.AddWithValue("@params5",kateqoriya);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void stok_azaltma()
        {

        }




    }
}
