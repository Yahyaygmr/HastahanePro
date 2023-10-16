using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahanePro
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4QIIH5S;Initial Catalog=HastahaneDb;Integrated Security=True");
            baglan.Open();
            return baglan; 
        }
    }
}
