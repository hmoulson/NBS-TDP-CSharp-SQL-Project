using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tool_and_Report__TDP_Project_
{
    class AddRecordtoSQL
    {
        SQL_Connector sQL_Connector = new SQL_Connector();
        public void addingRecord()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("To add a sale, please enter the:");
                Console.WriteLine("1 - Product Name");
                string name = Console.ReadLine();
                Console.WriteLine("2 - Quantity");
                try
                {
                    int quantity = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("3 - Price");
                    try
                    {
                        float price = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("You have entered:");
                        Console.WriteLine(name + ", " + quantity + ", " + price);
                        Console.WriteLine("--");
                        Console.WriteLine("Confirm Submission");
                        Console.WriteLine("Y/N");
                        string approval = Console.ReadLine();

                        if (approval == "Y" || approval == "y")
                        {
                            sQL_Connector.addsale(name, quantity, price);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
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
