using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texttomeh2.Events;

namespace Texttomeh2
{
    public partial class World : Form
    {
        public int cardNum;
        public Dictionary<int, Form> cards;

        // Delegate
        public delegate void CardsHandler(object sender, UpdateCardsEventsArgs e);

        //Event for Delegate 
        //Type CardsHandler matches the Delegate above
        //UpdateCards is the variable used by Novels form
        public event CardsHandler UpdateCards;

        // counts number of closes
        private int CloseCount = 0;

        // numbers used to determine location of added buttons
        private int numXLabel = 315;
        private int numYLabel = 79;
        private int numXTB = 438;
        private int numYTB = 79;
        private int addCount = 0;

        public World()
        {
            InitializeComponent();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CloseCount == 0)
            {
                MessageBox.Show(cardNum.ToString());
                UpdateCardsEventsArgs args = new UpdateCardsEventsArgs(cards);
                cards.Add(cardNum, this);
                //Event declared above
                CloseCount += 1;
                UpdateCards(this, args);
            }
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTB_Click(object sender, EventArgs e)
        {
            if (addCount >= 7)
            {
                MessageBox.Show("Too many TBs!");
            }
            else
            {
                TextBox myTB = new TextBox();
                myTB.Location = new Point(numXTB, numYTB);
                myTB.Size = new Size(128, 20);
                myTB.Name = "progCreTB";
                myTB.Font = new Font("MS Sans Serif", 8.25f);

                // Adding TB to form
                this.Controls.Add(myTB);
                myTB.BringToFront();
                numYTB += 20 + 6;
                addCount += 1;

                TextBox myLB = new TextBox();
                myLB.Location = new Point(numXLabel, numYLabel);
                myLB.Size = new Size(110, 20);
                myLB.Name = "progCreLB";
                myLB.Font = new Font("MS Sans Serif", 12f);
                myLB.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.GradientInactiveCaption);
                myLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                // Adding TB to form
                this.Controls.Add(myLB);
                myLB.BringToFront();
                numYLabel += 20 + 6;
                addCount += 1;
            }
        }

        private void worldName_TextChanged(object sender, EventArgs e)
        {
            this.Name = worldName.Text;
        }
    }
}
