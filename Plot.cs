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
    public partial class Plot : Form
    {
        public int cardNum;
        public Dictionary<int, Form> cards;

        // Delegate
        public delegate void CardsHandler(Form sender, UpdateCardsEventsArgs e);

        //Event for Delegate 
        //Type CardsHandler matches the Delegate above
        //UpdateCards is the variable used by Novels form
        public event CardsHandler UpdateCards;
        public event CardsHandler DeleteCards;

        // counts number of closes
        private int CloseCount = 0;

        // numbers used to determine location of added buttons
        private int numXLabel = 315;
        private int numYLabel = 79;
        private int numXTB = 438;
        private int numYTB = 79;
        private int addCount = 0;
        public Plot()
        {
            InitializeComponent();
            this.Visible = true;
            this.SetControls();
        }
        private void SetControls()
        {
            // makes form uneditable to user
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean nameExists = false;

            for (int key = 0; key < cards.Count(); key++)
            {
                Form f = cards[key];
                if ((this.Name == f.Name) && (this != f))
                {
                    nameExists = true;
                }
                // do what you wish with key and value here
            }
            if (nameExists)
            {
                MessageBox.Show("This name already exists! You must change the name.");
            }
            else
            {
                if (CloseCount == 0)
                {

                    UpdateCardsEventsArgs args = new UpdateCardsEventsArgs(cards);
                    cards.Add(cardNum, this);
                    //Event declared above
                    CloseCount += 1;
                    UpdateCards(this, args);
                }
                this.Visible = false;
            }
        }

        private void eventName_TextChanged(object sender, EventArgs e)
        {
            this.Name = eventName.Text;
        }

        private void addBox_Click(object sender, EventArgs e)
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
        private void button4_Click(object sender, EventArgs e)
        {
            UpdateCardsEventsArgs args = new UpdateCardsEventsArgs(cards);
            if (CloseCount >= 0)
            {
                DeleteCards(this, args);
            }
            this.Close();
        }
    }
}
