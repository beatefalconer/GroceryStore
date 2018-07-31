using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore1
{
    public partial class Form1 : Form
    {
        int totalA = 0;
        int totalB = 0;
        int priceA = 30;
        int priceB = 50;
        int special = 4;
        double totalCost = 0;
            public Form1()
        {

            InitializeComponent();
            //public int totalA = 0;
            //public int totalB = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalA = totalA + 1;
            textBoxAppleCount.Text = totalA.ToString();
            textBoxAppleInput.Text = totalA.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalB = totalB + 1;
            textBoxBananaCount.Text = totalB.ToString();
            textBoxBananaInput.Text = totalB.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totalCost = priceA * totalA + priceB * (totalB / (special + 1)) * special + priceB * (totalB % (special + 1));
            totalCost = totalCost / 100;
            textBoxTotalPrice.Text = String.Format(totalCost.ToString("C2"));

            CheckoutPanel.Show();
            ShoppingPanel.Hide();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
