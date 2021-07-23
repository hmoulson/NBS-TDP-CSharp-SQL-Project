using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tool_and_Report__TDP_Project_
{
    class Program
    {
        static void Main(string[] args)
        {
            SQL_Connector sQL_Connector = new SQL_Connector();
            AddRecordtoSQL addRecordtoSQL = new AddRecordtoSQL();
            Reporting reporting = new Reporting();
            int selec1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Select from the Following:");
                Console.WriteLine("");
                Console.WriteLine("1 - Data Entry");
                Console.WriteLine("2 - Reports");
                Console.WriteLine("0 - Exit");
                try
                {
                    selec1 = Int32.Parse(Console.ReadLine());
                    if (selec1 == 0)
                    {
                        break;
                    }
                    else if (selec1 == 1) //Data Entry
                    {
                        addRecordtoSQL.addingRecord();
                    }
                    else if (selec1 == 2) //Reports
                    {
                        reporting.reportingonSQL();
                    }
                    else
                    {
                        continue;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
