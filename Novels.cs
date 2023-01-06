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
    // novel page where user can view contents of a novel
    public partial class Novels : Form
    {
        // pointer used to track
        private int pointer = 0;
        //numbers used to determine buttons placement
        private int novelLocX = 12;
        private int novelLocY = 60;
        // counts number of closes
        private int CloseCount = 0;
        private int cardNum;
        

        // variables that stores all novels, currently storing characters for code testing purposes
        public Dictionary<int, Form> novels = new Dictionary<int, Form>();
        public Dictionary<int, Form> cards = new Dictionary<int, Form>();
        public Dictionary<String, int> addedButtons = new Dictionary<String, int>();
        public int novelNum;

        //Delegate
        public delegate void NovelsHandler(object sender, UpdateNovelsEventsArgs e);

        //Event for Delegate 
        //Type NovelsHandler matches the Delegate above
        //UpdateNovels is the variable used by Homepage form
        public event NovelsHandler UpdateNovels;

       //start
        public Novels()
        {
            InitializeComponent();
            this.Visible = true;
            cardNum = 0;
        }

        private void Novels_Load(object sender, EventArgs e)
        {
            
        }

        private void novelName_TextChanged(object sender, EventArgs e)
        {
            this.Name = novelName.Text;
        }

        // adds cards
        private void addNewCard_Click(object sender, EventArgs e)
        {
            // opens option page for options to create new novel/char/plot/world
            OptionPage optionForm = new OptionPage();
            optionForm.cards = this.cards;

            //sets up the communication-between-forms event handler
            optionForm.UpdateCards += new OptionPage.CardsHandler(cardsUpdate);
            optionForm.cardNum = this.cardNum;
        }

        // adds button linked to recently closed card
        private void cardsUpdate(object s, UpdateCardsEventsArgs e)
        {
            cardNum += 1;
            cards = e.GetCards;

            /*math for buttons
             * start at 12, 60
             * size 134, 180
             * split width still 6
             */
            Button cardButton = new Button();
            cardButton.Location = new Point(novelLocX, novelLocY);
            cardButton.Size = new Size(134, 180);
            cardButton.Name = cards[pointer].Name;
            cardButton.Text = cards[pointer].Name;
            cardButton.Click += new EventHandler(this.cardButton_Click);
            this.Controls.Add(cardButton);
            addedButtons.Add(cardButton.Text, cardNum - 1);
            pointer += 1;
            novelLocX += 134 + 6;

        }
        
        // new button click event utilizing inherited pointers
        private void cardButton_Click(object sender, EventArgs e)
        {
            String splicing = sender.ToString().Split(':')[1].Substring(1);
            MessageBox.Show(addedButtons[splicing].ToString());
            cards[addedButtons[splicing]].Visible = true;

        }

        // saving
        private void save_Click(object sender, EventArgs e)
        {
            if (CloseCount == 0)
            {
                UpdateNovelsEventsArgs args = new UpdateNovelsEventsArgs(novels);
                novels.Add(novelNum, this);
                //Event declared above
                UpdateNovels(this, args);
                CloseCount += 1;
            }
            
            this.Visible = false;
        }

        //deletes form
        private void delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
