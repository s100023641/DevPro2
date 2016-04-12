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
    public partial class Form1 : Form
    {
        public Sale CurrentSale;
        public Form1()
        {
            CurrentSale = new Sale();
            InitializeComponent();
            SetListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SetListBox() {
            listBox1.Items.Clear();
            string connStr = "server=localhost;user=root;database=pharmacydb;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Random r= new Random();
                int orderNumb=r.Next();
                // Perform database operations
                string sqlText = "SELECT * FROM `stockableitems`";
                Console.WriteLine(sqlText);
                MySqlCommand cmd = new MySqlCommand(sqlText, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                while(rdr.Read()){
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Sale.SaleItem SI = new Sale.SaleItem(listBox1.Text, listBox1.SelectedIndex+1, int.Parse(textBox2.Text), double.Parse(textBox1.Text));
            Console.WriteLine(SI.buildSQL("44"));
            textBox3.Text += SI.buildSQL("44");

            CurrentSale.items.Add(SI);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentSale.RecordToDatabase();
            CurrentSale = new Sale();
        }
    }
}
