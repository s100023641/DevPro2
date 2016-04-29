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
    public partial class frmStock : Form
    {
        public Sale CurrentStock;
        public frmStock()
        {
            CurrentStock = new Sale();
            InitializeComponent();
            SetStockName();
            SetStockQty();
            SetStockID();
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        public void SetStockName()
        {
            listBox1.Items.Clear();
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems`";
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr[1]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }


        public void SetStockQty()
        {

            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                listBox2.Items.Clear();
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems`";
                Console.WriteLine(sqlText);

                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox2.Items.Add(rdr[2]);
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        public void SetStockID()
        {
            listBox3.Items.Clear();
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems`";
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox3.Items.Add(rdr[0]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void Random()
        {
            throw new NotImplementedException();
        }

        public void SetFilteredStockName()
        {
            
            listBox1.Items.Clear();
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems` where itemID = " + textBox1.Text;
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr[1]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }


        public void SetFilteredStockQty()
        {

            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                listBox2.Items.Clear();
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems` where itemID = " + textBox1.Text;
                Console.WriteLine(sqlText);

                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox2.Items.Add(rdr[2]);
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        public void SetFilteredStockID()
        {
            listBox3.Items.Clear();
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems` where itemID = " + textBox1.Text;
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox3.Items.Add(rdr[0]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            AppController.Main.Back();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            SetStockName();
            SetStockQty();
            SetStockID();  

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            
            SetFilteredStockID();
            SetFilteredStockName();
            SetFilteredStockQty();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "UPDATE `stockableitems` SET `Quantity`= " + textBox2.Text +" WHERE itemID = " + textBox1.Text ;
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r = new Random();
                int orderNumb = r.Next();
                // Perform database operations
                string sqlText = "INSERT INTO `stockableitems`(`itemID`, `Name`, `Quantity`) VALUES (" + textBox1.Text +  ", '" + textBox3.Text + "'," + textBox2.Text + ")";
                //string sqlText = "INSERT INTO `stockableitems`(`itemID`, `Name`, `Quantity`) VALUES ("," + textBox3.Text + "," + textBox2.Text + ")";
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
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
