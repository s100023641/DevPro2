﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDatabaseFrontEnd
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppController.Main.ChangeState("Sales");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppController.Main.ChangeState("Stock");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppController.Main.ChangeState("AddSales");
        }
    }
}
