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
using Texttomeh2.Models;

namespace Texttomeh2
{
    // novel page where user can view contents of a novel
    public partial class Novel : Form
    {
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
        public delegate void NovelsHandler(Form sender, UpdateNovelsEventsArgs e);

        //Event for Delegate 
        //Type NovelsHandler matches the Delegate above
        //UpdateNovels is the variable used by Homepage form
        public event NovelsHandler UpdateNovels;
        public event NovelsHandler DeleteNovels;

        //for exporting purposes
        private string txtLocation = "";

        //start
        public Novel()
        {
            InitializeComponent();
            this.Visible = true;
            cardNum = 0;
        }

        private void Novels_Load(object sender, EventArgs e)
        {
            this.SetControls();
            this.ControlBox = false;
        }

        private void SetControls()
        {
            // makes form uneditable to user
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            optionForm.DeleteCards += new OptionPage.CardsHandler(cardsDelete);
            optionForm.cardNum = this.cardNum;
        }

        // adds button linked to recently closed card
        private void cardsUpdate(Form s, UpdateCardsEventsArgs e)
        {
            
            cards = e.GetCards;

            /*math for buttons
             * start at 12, 60
             * size 134, 180
             * split width still 6
             */
            Button cardButton = new Button();
            cardButton.Location = new Point(novelLocX, novelLocY);
            cardButton.Size = new Size(134, 180);
            cardButton.Name = cards[cardNum].Name;
            cardButton.Text = cards[cardNum].Name;
            cardButton.Click += new EventHandler(this.cardButton_Click);
            this.Controls.Add(cardButton);

            cardNum += 1;
            addedButtons.Add(cardButton.Text, cardNum - 1);
            novelLocX += 134 + 6;

            if(novelLocX >= 854)
            {
                novelLocX = 12;
                novelLocY += 190;
            }

        }
        
        // new button click event utilizing inherited pointers
        private void cardButton_Click(object sender, EventArgs e)
        {
            String splicing = sender.ToString().Split(':')[1].Substring(1);
            cards[addedButtons[splicing]].Visible = true;

        }

        // saving
        private void save_Click(object sender, EventArgs e)
        {
            Boolean nameExists = false;

            for (int key = 0; key < cards.Count(); key ++)
            {
                Form f = cards[key];
                if (this.Name == f.Name)
                {
                    nameExists = true;
                }

            }
            if (nameExists)
            {
                MessageBox.Show("This name already exists! You must change the name.");
            }
            else
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
        }

        //deletes form
        private void delete_Click(object sender, EventArgs e)
        {
            UpdateNovelsEventsArgs args = new UpdateNovelsEventsArgs(cards);

            DialogResult dr = MessageBox.Show("Are you sure you would like to delete?", "Deleting form...", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    if (CloseCount > 0)
                    {
                        DeleteNovels(this, args);
                    }

                    this.Close();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Returning to novel...");
                    break;
            }

        }

        private void cardsDelete(Form s, UpdateCardsEventsArgs e)
        {

            cards = e.GetCards;
            String cardName = s.Name;
            cards[addedButtons[cardName]].Close();
            cards.Remove(addedButtons[cardName]);
            addedButtons.Remove(cardName);

            foreach (Control c in this.Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    if (b.Name == cardName)
                    {
                        b.Hide();
                    }
                }
            }
        }

        private void exportAll_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = CurrentPath.GetDbasePath();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtLocation = folderBrowserDialog1.SelectedPath;
            }

            string file = this.txtLocation.Trim() + "\\" + this.Name.Trim();
            foreach (KeyValuePair<int, Form> entry in cards)
            {
                ExportTXT.WriteTXT(entry.Value, file + entry.Value.Name + ".txt");
            }
        }
    }
}
