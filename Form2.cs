using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texttomeh2
{
    public partial class Form2 : Form
    {
        private int numXLabel = 315;
        private int numYLabel = 79;
        private int numXTB = 431;
        private int numYTB = 79;

        private int CloseCount = 0;
        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
   
        }

        //currently fixing
        //private void CreateTextBoxDelegate(object sender, EventArgs e)
        //{
        //    TextBox newTB = new TextBox();
        //    this.Controls.Add(newTB);
        //    newTB.Text = "Created Button";
        //    newTB.Location = new Point(600, 300);
        //    newTB.Size = new Size(50, 100);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //currently fixing
            //TextBox newTB = new TextBox();
            //this.Controls.Add(newTB);
            //newTB.Text = "Created TB";
            //newTB.Location = new Point(700, 300);
            //newTB.Size = new Size(50, 100);
            ////newTB.Visible = true;
            /* Start of Math
             * 
             * 309 70, label is +6+9 for 1st
             * 
             * +122+9 for 1st TB
             * 
             * 110, 20 for labels
             * 128, 20 for TB
             * +6 between stuff
             */
            

            TextBox myTB = new TextBox();
            myTB.Location = new Point(numXTB, numYTB);
            myTB.Text = "Submit";
            myTB.Size = new Size(128, 20);
            myTB.BackColor = Color.LightBlue;
            myTB.Padding = new Padding(6);
            myTB.Name = "First_button";

            // Adding this button to form
            this.Controls.Add(myTB);
            myTB.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (CloseCount == 0)
            {
               
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }




}
