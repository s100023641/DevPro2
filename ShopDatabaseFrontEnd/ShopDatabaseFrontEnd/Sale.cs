using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data;
//using MySql.Data.MySqlClient;

namespace ShopDatabaseFrontEnd
{
    public class Sale
    {

        public List<SaleItem> items;
        public Sale() {
            items = new List<SaleItem>();
        }
        public class SaleItem{

            public SaleItem(string nameA, int numA, int qA, double pA) {
                name = nameA;
                itemNumber = numA;
                quanity = qA;
                price = pA;
            }
            public int itemNumber;
            public string name;
            public int quanity;
            public double price;

            public string buildSQL(string SaleID) {
                
                return string.Format("INSERT INTO `orderitem` (`OrderNum`, `ItemID`, `ItemAmount`, `Price`) VALUES ({0}, {1}, {2}, {3:N2});", SaleID, itemNumber, quanity, price);
            }
        }

        public double TotalCost {
            get {
                double total = 0;
                foreach (var item in items)
                {
                    total += item.price;
                }
                return total;
            }
        }

        public void RecordToDatabase() {
        /*    string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r= new Random();
                int orderNumb=r.Next();
                // Perform database operations
                string sqlText = string.Format("INSERT INTO `ordersale` (`OrderNum`, `Timestamp`) VALUES ({0}, CURRENT_TIMESTAMP)", orderNumb);
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                foreach (var item in items)
                {
                    string itemSQL = item.buildSQL(orderNumb.ToString());
                    Console.WriteLine(itemSQL);
                    MySqlCommand cmd2 = new MySqlCommand(itemSQL, conn);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    rdr2.Close();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            
            Console.WriteLine("Done.");
               //insert sale at currentTime
                */

            //close database boiler plate code;
        }
    }
}
