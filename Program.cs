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
            int numcol;
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
                    else if (selec1 == 2) //Reports
                    {
                        while (true)
                        {
                            int selec2;
                            Console.Clear();
                            Console.WriteLine("Please Select a Report from the Following:");
                            Console.WriteLine("");
                            Console.WriteLine("1 - List of Products sold in a Specific Year");
                            Console.WriteLine("2 - List of Products sold in a Specific Month");
                            Console.WriteLine("3 - Total Sales for a Specific Year");
                            Console.WriteLine("4 - Total Sales for a Specific Month");
                            Console.WriteLine("0 - Exit");
                            try
                            {
                                selec2 = Int32.Parse(Console.ReadLine());
                                if (selec2 == 0)
                                {
                                    break;
                                }
                                else if (selec2 == 1 || selec2 == 2)
                                {
                                    numcol = 2;
                                    string search = "select productname,count(productname) as 'total number of sales' from sales where ";
                                    int month;
                                    while (true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter a Year:");
                                        try
                                        {
                                            int Year = Int32.Parse(Console.ReadLine());

                                            search = search + "Extract(Year from SaleDate)=" + Year;

                                            if (selec2 == 2)
                                            {
                                                Console.WriteLine("Please enter a Month:");
                                                try
                                                {
                                                    month = Int32.Parse(Console.ReadLine());
                                                    search = search + " and Extract(Month from SaleDate)=" + month;
                                                }
                                                catch
                                                {
                                                    continue;
                                                }
                                            }
                                            search = search + " group by productname order by count(productname) desc;";

                                            Console.Clear();
                                            Console.WriteLine("Product..Total Sales");
                                            sQL_Connector.returnrecords(numcol, search);
                                            Console.Read();
                                            break;
                                        }
                                        catch
                                        {
                                            continue;
                                        }
                                    }
                                }
                                else if (selec2 == 3 || selec2 == 4)
                                {
                                    string search = "sum(quantity) as 'total sold',sum(quantity*prices) as 'total revenue' from sales where ";
                                    int month;
                                    while (true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter a Year:");
                                        try
                                        {
                                            int Year = Int32.Parse(Console.ReadLine());

                                            search = search + "Extract(Year from SaleDate)=" + Year;

                                            if (selec2 == 4)
                                            {
                                                Console.WriteLine("Please enter a Month in numeric form:");
                                                try
                                                {
                                                    month = Int32.Parse(Console.ReadLine());
                                                    search = search + " and Extract(Month from SaleDate)=" + month;
                                                }
                                                catch
                                                {
                                                    continue;
                                                }
                                            }

                                            Console.WriteLine("View by Product? Y/N");
                                            while (true)
                                            {
                                                string selec3 = Console.ReadLine();

                                                if (selec3 == "Y" || selec3 == "y" || selec3 == "Yes" || selec3 == "yes")
                                                {
                                                    numcol = 3;
                                                    search = "select productname," + search;
                                                    search += " group by productname order by count(productname) desc;";
                                                    Console.Clear();
                                                    Console.WriteLine("Product..Total Quantity Sold..Total Revenue");
                                                    sQL_Connector.returnrecords(numcol, search);
                                                    Console.Read();
                                                    break;
                                                }
                                                else if (selec3 == "N" || selec3 == "n" || selec3 == "No" || selec3 == "no")
                                                {
                                                    numcol = 2;
                                                    search = "select " + search;
                                                    search += ";";
                                                    Console.Clear();
                                                    Console.WriteLine("Total Quantity Sold..Total Revenue");
                                                    sQL_Connector.returnrecords(numcol, search);
                                                    Console.Read();
                                                    break;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                            break;
                                        }
                                        catch
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                            }
                            catch
                            {
                                continue;
                            }
                        }
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
