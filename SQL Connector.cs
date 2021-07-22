using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sales_Tool_and_Report__TDP_Project_
{
    class SQL_Connector
    {
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;

        public SQL_Connector()
        {
            string connectionstring = "server=localhost;user=root;password=root;database=shop_tdp";
            sqlcon = new MySqlConnection(connectionstring);
            sqlcon.Open();
            sqlcmd = new MySqlCommand();
            sqlcmd.Connection = sqlcon;
        }

        public void addsale(string Product, int quantity, float price)
        {
            sqlcmd.CommandText = $"insert into sales(ProductName,Quantity,Prices) values('{Product}',{quantity},{price});";
            sqlcmd.ExecuteNonQuery();
        }

      
        public void returnrecords(int numcol,string sqlsearchscript)
        {
            
            sqlsearch(numcol, sqlsearchscript);
            Console.Read();
        }

        private void sqlsearch(int numcol,string sqlscript)
        {
            sqlcmd.CommandText = sqlscript;
            MySqlDataReader data = sqlcmd.ExecuteReader();

            if (numcol == 2)
            {
                while (data.Read())
                {
                    Console.WriteLine(data[0] + "....." + data[1]);
                }
            }
            if (numcol == 3)
            {
                while (data.Read())
                {
                    Console.WriteLine(data[0] + "....." + data[1] + "....." + data[2]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            data.Close();
        }
    }
}
