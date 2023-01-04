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
        // track what button is linked to what novel
        private int pointer = 0;

        // tracks new button locations
        private int novelLocX = 12;
        private int novelLocY = 60;

        // list that stores all novels, currently storing characters for code testing purposes
        public Dictionary<int,Form> novels = new Dictionary<int,Form>();
        public Dictionary<String, int> addedButtons = new Dictionary<String, int>();

        private int novelNum;

        public Homepage()
        {
            InitializeComponent();
            novelNum = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // opens option page for options to create new novel
            Novels novel = new Novels();
            novel.novels = this.novels;

            //sets up the communication-between-forms event handler
            novel.UpdateNovels += new Novels.NovelsHandler(novelsUpdate);

            //set pointer for novel
            novel.novelNum = this.novelNum;
        }

        private void novelsUpdate(object s, UpdateNovelsEventsArgs e)
        {
            novelNum += 1;
            //currently testing using this to check, will eventually changed to added buttons
            novels = e.GetNovels;

            /*math for buttons
             * start at 12, 60
             * size 134, 180
             * split width still 6
             */
            Button novelButton = new Button();
            novelButton.Location = new Point(novelLocX, novelLocY);
            novelButton.Size = new Size(134, 180);
            novelButton.Name = novels[pointer].Name;
            novelButton.Text = novels[pointer].Name;
            novelButton.Click += new EventHandler(this.novelButton_Click);
            this.Controls.Add(novelButton);
            addedButtons.Add(novelButton.Text, novelNum-1);
            pointer += 1;
            novelLocX += 134 + 6;
            
        }

        private void novelButton_Click(object sender, EventArgs e)
        {
            String splicing = sender.ToString().Split(':')[1].Substring(1);
            MessageBox.Show(addedButtons[splicing].ToString());
            int location = addedButtons[splicing];
            novels[location].Visible = true;
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //makes form uneditable to user
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
