using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ShopDatabaseFrontEnd
{
    public partial class frmSales : Form
    {
        BindingSource bind1 = new BindingSource();
        BindingSource bind2 = new BindingSource();
        int week;
        int month;



        public frmSales()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            month = 1;
            week = 1;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bind1;
            RefreshGridView1();

            dataGridView2.DataSource = bind2;
            RefreshGridView2();
        }

        private void GridViewData(string sqlCommand, BindingSource bind)
        {
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand, connStr);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            bind.DataSource = table;
        }

        private void RefreshGridView1()
        {
            GridViewData("SELECT OrderItem.ItemID, StockableItems.Name, OrderItem.ItemAmount, OrderItem.Price, MONTHNAME(ordersale.Timestamp) as Month, WEEK(ordersale.Timestamp, 5) " +
                        "- WEEK(DATE_SUB(ordersale.Timestamp, INTERVAL DAYOFMONTH(ordersale.Timestamp) - 1 DAY), 5) + 1 as Week FROM OrderItem INNER JOIN OrderSale ON OrderItem.OrderNum = OrderSale.OrderNum " +
                        "INNER JOIN StockableItems ON OrderItem.ItemID = StockableItems.ItemID WHERE(WEEK(ordersale.Timestamp, 5) - WEEK(DATE_SUB(ordersale.Timestamp, INTERVAL DAYOFMONTH(ordersale.Timestamp) - 1 DAY), 5) + 1) = " + week +
                        " AND MONTH(ordersale.Timestamp) = " + month +" ORDER BY OrderSale.TimeStamp;", bind1);
        }

        private void RefreshGridView2()
        {
            GridViewData("SELECT OrderItem.ItemID, StockableItems.Name, OrderItem.ItemAmount, OrderItem.Price, MONTHNAME(ordersale.Timestamp) as Month, WEEK(ordersale.Timestamp, 5) " +
                        "- WEEK(DATE_SUB(ordersale.Timestamp, INTERVAL DAYOFMONTH(ordersale.Timestamp) - 1 DAY), 5) + 1 as Week FROM OrderItem INNER JOIN OrderSale ON OrderItem.OrderNum = OrderSale.OrderNum " +
                        "INNER JOIN StockableItems ON OrderItem.ItemID = StockableItems.ItemID WHERE MONTH(ordersale.Timestamp) = " + month + " ORDER BY OrderSale.TimeStamp;", bind2);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AppController.Main.Back();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    week = 1;
                    RefreshGridView1();
                    break;
                case 1:
                    week = 2;
                    RefreshGridView1();
                    break;

                case 2:
                    week = 3;
                    RefreshGridView1();
                    break;

                case 3:
                    week = 4;
                    RefreshGridView1();
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    month = 1;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 1:
                    month = 2;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 2:
                    month = 3;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 3:
                    month = 4;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 4:
                    month = 5;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 5:
                    month = 6;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 6:
                    month = 7;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 7:
                    month = 8;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 8:
                    month = 9;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 9:
                    month = 10;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 10:
                    month = 11;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
                case 11:
                    month = 12;
                    RefreshGridView1();
                    RefreshGridView2();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText;
                if (tabControl1.SelectedIndex == 0)
                {
                    sqlText = "SELECT OrderItem.ItemID, StockableItems.Name, OrderItem.ItemAmount, OrderItem.Price, MONTHNAME(ordersale.Timestamp) as Month, WEEK(ordersale.Timestamp, 5) " +
                               "- WEEK(DATE_SUB(ordersale.Timestamp, INTERVAL DAYOFMONTH(ordersale.Timestamp) - 1 DAY), 5) + 1 as Week FROM OrderItem INNER JOIN OrderSale ON OrderItem.OrderNum = OrderSale.OrderNum " +
                               "INNER JOIN StockableItems ON OrderItem.ItemID = StockableItems.ItemID WHERE(WEEK(ordersale.Timestamp, 5) - WEEK(DATE_SUB(ordersale.Timestamp, INTERVAL DAYOFMONTH(ordersale.Timestamp) - 1 DAY), 5) + 1) = " + week +
                               " AND MONTH(ordersale.Timestamp) = " + month + " ORDER BY OrderSale.TimeStamp;";
                }
                else
                {
                    sqlText = "SELECT OrderItem.ItemID, StockableItems.Name, OrderItem.ItemAmount, OrderItem.Price, MONTHNAME(ordersale.Timestamp) as Month, WEEK(ordersale.Timestamp, 5) " +
                            "- WEEK(DATE_SUB(ordersale.Timestamp, INTERVAL DAYOFMONTH(ordersale.Timestamp) - 1 DAY), 5) + 1 as Week FROM OrderItem INNER JOIN OrderSale ON OrderItem.OrderNum = OrderSale.OrderNum " +
                            "INNER JOIN StockableItems ON OrderItem.ItemID = StockableItems.ItemID WHERE MONTH(ordersale.Timestamp) = " + month + " ORDER BY OrderSale.TimeStamp;";
                }
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output += rdr[0] + "," + rdr[1] + "," + rdr[2] + "," + rdr[3] + "," + rdr[4] + "," + rdr[5]+'\n';
                }
                Clipboard.SetText(output);
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
