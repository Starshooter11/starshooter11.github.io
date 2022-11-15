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
    public partial class OptionPage : Form
    {
        //Delegate
        public delegate void NovelsHandler(object sender, UpdateNovelsEventsArgs e);

        //Event for Delegate 
        //Type NovelsHandler matches the Delegate above
        //UpdateNovels is the variable used by Homepage form
        public event NovelsHandler UpdateNovels;


        public List<Form> novels;
        public OptionPage()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character charForm = new Character();

            //temporary for testing, will be changed to a list for chars later
            charForm.novels = this.novels;
            charForm.UpdateNovels += new Character.NovelsHandler(UpdateNovels);

            this.Close();

            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Plot plotForm = new Plot();
            this.Close();

            UpdateNovelsEventsArgs args = new UpdateNovelsEventsArgs(novels);

            //Event declared above
            UpdateNovels(this, args);
        }

        
    }
}
