using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kitabxana
{
    class Muellifler
    {
        public int muellif_id { get; set; }
        public string muellif_ad { get; set; }
        public int kitab_id { get; set; }

        connectionstring cc = new connectionstring();

        public void muellif_elave_et(string _ad,int _kitabid)
        {
            muellif_ad = _ad;
            kitab_id = _kitabid;
            SqlConnection con = new SqlConnection(cc.connection);
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            string muellif_elave = "INSERT INTO dbo.muelliflerr (ad,kitab_id) values (@params1,@params2)";
            SqlCommand cmd = new SqlCommand(muellif_elave);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@params1", muellif_ad);
            cmd.Parameters.AddWithValue("@params2", kitab_id);
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
