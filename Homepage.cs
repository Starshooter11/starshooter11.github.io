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
    // this is the homepage screen of the application
    public partial class Homepage : Form
    {
        private int pointer = -1; //used to keep track of novels
        private int novelLocX = 12; // used to keep track of button locations
        private int novelLocY = 60; // used to keep track of button locations

        // list that stores all novels, currently storing characters for code testing purposes
        public List<Form> novels = new List<Form>();

        //used to track different card counts
        private int charNum;
        private int plotNum;
        private int worldNum;

        //intializing
        public Homepage()
        {
            InitializeComponent();
            charNum = 0;
            plotNum = 0;
            worldNum = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // opens option page for options to create new novel/char/plot/world
            OptionPage optionForm = new OptionPage();
            optionForm.novels = this.novels;

            //sets up the communication-between-forms event handler
            optionForm.UpdateNovels += new OptionPage.NovelsHandler(novelsUpdate);

            //set pointer for char/plot/world
            optionForm.charNum = this.charNum;
            optionForm.plotNum = this.plotNum;
            optionForm.worldNum = this.worldNum;
        }

        private void novelsUpdate(object s, UpdateNovelsEventsArgs e)
        {
            pointer += 1;
            //currently testing using this to check, will eventually changed to added buttons
            novels = e.GetNovels;

            /* numbers for buttons
             * start at 12, 60
             * size 134, 180
             * split width still 6
             */

            // creates new button to open-close novels
            Button novelButton = new Button();
            novelButton.Location = new Point(novelLocX, novelLocY);
            novelButton.Size = new Size(134, 180);
            novelButton.Name = novels[pointer].Name;
            novelButton.Text = novels[pointer].Name;
            novelButton.Click += new EventHandler(this.novelButton_Click);
            this.Controls.Add(novelButton);

            novelLocX += 134 + 6;

        }

        private void novelButton_Click(object sender, EventArgs e)
        {
            novels[pointer].Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // centers form
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            // makes form uneditable to user
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }







}



}
