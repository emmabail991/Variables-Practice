using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class textBox : Form
    {


        public textBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        private void hockey_Click(object sender, EventArgs e)
        {   //strings and intager values 
            string playerName = "Wayne Gretzky";
            int playerNumber;
            playerNumber = 99;

            //Hockey button output
            outputLabel.Text = $"{playerName} is number {playerNumber}";







        }

        private void area_Click(object sender, EventArgs e)
        {   //bouble values
            double radius, pi, area;
            radius = 15;
            pi = 3.14;
            area = radius * pi;

            //Area button output 
            outputLabel.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2";

        }

        private void carpet_Click(object sender, EventArgs e)
        {
            double length, width, costPerMeter, area, totalCost;
            width = 6;
            length = 8.5;
            costPerMeter = 19.95;
            area = width * length;
            totalCost = costPerMeter * area;

            outputLabel.Text = $"\nThe area of the room with the demensions of {width}m and {length}m is {area}m^2";
            outputLabel.Text += $"\n\nThe cost to carpet this are at ${costPerMeter} per square meter is ${totalCost}";
        }

        private void bill_Click(object sender, EventArgs e)
        {
             
            double shirt, tax, taxTotal, total, payed, change;
            shirt = 12.49;
            tax = 0.13;
            payed = 20.00;
            taxTotal = tax * shirt;
            total = taxTotal + shirt;
            change = payed - total;


            //bill output
            outputLabel.Text = "\nBill of Sale";
            outputLabel.Text += $"\n\nShirt:                   ${shirt}";
            //tax and total 
            outputLabel.Text += $"\n\nTax:" +
             $"{taxTotal.ToString("#.##")}";

            outputLabel.Text += $"\nTotal:                  ${taxTotal.ToString("#.##")}";

            //amount payed and change 
            outputLabel.Text += $"\n\nTendered:           ${payed}";
            outputLabel.Text += $"\nChange:              ${change.ToString("#.##")}";





        }
            
    }
}
