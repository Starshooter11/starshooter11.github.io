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
    // option page where the creation of different 'cards' happens
    public partial class OptionPage : Form
    {
        // access to edit this list; will be used to pass on editing function to other forms
        public Dictionary<int, Form> cards;
        public int cardNum;

        //Delegate
        public delegate void CardsHandler(Form sender, UpdateCardsEventsArgs e);

        //Event for Delegate 
        //Type CardsHandler matches the Delegate above
        //UpdateCards is the variable used by Novel form
        public event CardsHandler UpdateCards;
        public event CardsHandler DeleteCards;

        // start
        public OptionPage()
        {
            InitializeComponent();
            this.Visible = true;
        }

        //character form button
        private void charButton_Click(object sender, EventArgs e)
        {
            Character charForm = new Character();
            charForm.cards = this.cards;
            charForm.UpdateCards += new Character.CardsHandler(UpdateCards);
            charForm.DeleteCards += new Character.CardsHandler(DeleteCards);
            charForm.cardNum = this.cardNum;
            this.Close();
        }

        // plot form button
        private void plotButton_Click(object sender, EventArgs e)
        {
            Plot plotForm = new Plot();
            plotForm.cards = this.cards;
            plotForm.UpdateCards += new Plot.CardsHandler(UpdateCards);
            plotForm.DeleteCards += new Plot.CardsHandler(DeleteCards);
            plotForm.cardNum = this.cardNum;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            World worldForm = new World();
            worldForm.cards = this.cards;
            worldForm.UpdateCards += new World.CardsHandler(UpdateCards);
            worldForm.DeleteCards += new World.CardsHandler(DeleteCards);
            worldForm.cardNum = this.cardNum;
            this.Close();
        }
    }
}
