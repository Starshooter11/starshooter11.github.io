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
        List<Form> contents = new List<Form>();

        public Dictionary<int, Form> cards = new Dictionary<int, Form>();

        private int cardNum = 0;
        private int closeCount = 0;
        public int novelNum;

        public Dictionary<String, int> addedButtons = new Dictionary<String, int>();

        public Dictionary<int, Form> novels;
        public delegate void NovelsHandler(object sender, UpdateNovelsEventsArgs e);
        public event NovelsHandler UpdateNovels;

        

        public Novels()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void Novelcs_Load(object sender, EventArgs e)
        {
            if (contents.Count == 0)
            {
                MessageBox.Show("This novel is currently empty!");
            }
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            // opens option page for options to create new novel/char/plot/world
            OptionPage optionForm = new OptionPage();
            optionForm.cards = this.cards;


            //sets up the communication-between-forms event handler
            optionForm.UpdateCards += new OptionPage.CardsHandler(cardsUpdate);

            //set pointer for char/plot/world
            optionForm.cardNum = 0;
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
            Button novelButton = new Button();
            /*novelButton.Location = new Point(novelLocX, novelLocY);
            novelButton.Size = new Size(134, 180);
            novelButton.Name = novels[pointer].Name;
            novelButton.Text = novels[pointer].Name;
            novelButton.Click += new EventHandler(this.novelButton_Click);
            this.Controls.Add(novelButton);
            addedButtons.Add(novelButton.Text, charNum - 1);
            pointer += 1;
            novelLocX += 134 + 6;
            */

        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            String splicing = sender.ToString().Split(':')[1].Substring(1);
            MessageBox.Show(addedButtons[splicing].ToString());
            int location = addedButtons[splicing];
            cards[location].Visible = true;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (closeCount == 0)
            {
                UpdateNovelsEventsArgs args = new UpdateNovelsEventsArgs(novels);
                novels.Add(novelNum, this);
                //Event declared above
                UpdateNovels(this, args);
            }
            closeCount += 1;
            this.Visible = false;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            this.Name = novelName.Text;
        }
    }
}
