using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sobel_filtering
{
    class Class2
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Emotion;Integrated Security=True");
        SqlCommand cmd;

        public int InDelUp(string qry)
        {
            cmd = new SqlCommand(qry, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }


        public DataSet Display(string qry)
        {

            SqlDataAdapter da = new SqlDataAdapter(qry, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "data");
            return ds;
        }
    }
}
