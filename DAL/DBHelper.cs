using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        string sjk = "Data Source=.;Initial Catalog=xmdb;Integrated Security=True";
        public int zsg(string sql)
        {
            SqlConnection lj = new SqlConnection(sjk);
            lj.Open();
            SqlCommand sj = new SqlCommand(sql,lj);
            return sj.ExecuteNonQuery();
        }
        public DataTable cha(string sql)
        {
            SqlConnection lj = new SqlConnection(sjk);
            lj.Open();
            SqlDataAdapter sj = new SqlDataAdapter(sql, lj);
            DataTable biao = new DataTable();
            sj.Fill(biao);
            return biao;
        }
    }
}
