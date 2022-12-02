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
        private int pointer = 0;
        private int novelLocX = 12;
        private int novelLocY = 60;

        // list that stores all novels, currently storing characters for code testing purposes
        public Dictionary<int, Form> novels = new Dictionary<int, Form>();
        public Dictionary<int, Form> cards = new Dictionary<int, Form>();
        public Dictionary<String, int> addedButtons = new Dictionary<String, int>();


        public delegate void NovelsHandler(object sender, UpdateNovelsEventsArgs e);
        public event NovelsHandler UpdateNovels;

        private int cardNum = 0;
        public int novelNum;
        public Novels()
        {
            InitializeComponent();
        }

        private void Novels_Load(object sender, EventArgs e)
        {
            if (cards.Count == 0)
            {
                MessageBox.Show("This novel is currently empty!");
            }
        }

        private void novelName_TextChanged(object sender, EventArgs e)
        {
            this.Name = novelName.Text;
        }

        private void addNewCard_Click(object sender, EventArgs e)
        {
            // opens option page for options to create new novel/char/plot/world
            OptionPage optionForm = new OptionPage();
            optionForm.novels = this.cards;

            //sets up the communication-between-forms event handler
            optionForm.UpdateCards += new OptionPage.CardsHandler(cardsUpdate);

            /*set pointer for char/plot/world
            optionForm.charNum = this.charNum;
            optionForm.plotNum = this.plotNum;
            optionForm.worldNum = this.worldNum;
            */
        }
        private void cardsUpdate(object s, UpdateCardsEventsArgs e)
        {
            cardNum += 1;
            //currently testing using this to check, will eventually changed to added buttons
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

        private void cardButton_Click(object sender, EventArgs e)
        {
            String splicing = sender.ToString().Split(':')[1].Substring(1);
            MessageBox.Show(addedButtons[splicing].ToString());
            cards[addedButtons[splicing]].Visible = true;

        }
    }
}
