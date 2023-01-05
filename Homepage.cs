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
    // this is the homepage screen of the application. it starts here
    public partial class Homepage : Form
    {
        // dictionaries that store novels and buttons added to form
        public Dictionary<int,Form> novels = new Dictionary<int,Form>();
        public Dictionary<String, int> addedButtons = new Dictionary<String, int>();

        // novel count used as an inherited key
        private int novelNum;

        // pointer used as a dictionary key
        private int pointer = 0;

        // numbers used to determine added buttons locations
        private int novelLocX = 12;
        private int novelLocY = 60;

        // start
        public Homepage()
        {
            InitializeComponent();
            novelNum = 0;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sets form
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


        // opens a novel editing UI
        private void button1_Click(object sender, EventArgs e)
        {
            // opens novel UI
            Novels novel = new Novels();
            novel.novels = this.novels;

            //sets up the communication-between-forms event handler
            novel.UpdateNovels += new Novels.NovelsHandler(novelsUpdate);

            // inherited pointer
            novel.novelNum = this.novelNum;
        }

        // adds a button linked to recently saved novel
        private void novelsUpdate(object s, UpdateNovelsEventsArgs e)
        {
            novelNum += 1;
            novels = e.GetNovels;

            /*math for buttons
             * start at 12, 60
             * size 134, 180
             * split width still 6
             */

            //new button
            Button novelButton = new Button();
            novelButton.Location = new Point(novelLocX, novelLocY);
            novelButton.Size = new Size(134, 180);
            novelButton.Name = novels[pointer].Name;
            novelButton.Text = novels[pointer].Name;
            novelButton.Click += new EventHandler(this.novelButton_Click);
            this.Controls.Add(novelButton);
            addedButtons.Add(novelButton.Text, novelNum-1);

            // location changes
            pointer += 1;
            novelLocX += 134 + 6;

        }

        // new button event utilizing pointers
        private void novelButton_Click(object sender, EventArgs e)
        {
            String splicing = sender.ToString().Split(':')[1].Substring(1);
            MessageBox.Show(addedButtons[splicing].ToString());
            novels[addedButtons[splicing]].Visible = true;
                
        }

        







}



}
