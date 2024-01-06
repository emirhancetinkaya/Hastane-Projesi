using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace udemy13._1_hastane_projesi
{
    internal class SqlBağlantısı
    {
        public SqlConnection bağlantı()
        {
            SqlConnection bağlan = new SqlConnection("Data Source=Emircet\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            bağlan.Open();
            return bağlan;
        }
    }
}
