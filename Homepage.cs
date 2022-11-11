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
    public partial class Homepage : Form
    {
        private int pointer = -1;

       
        public List<Form> novels = new List<Form>();

        public Homepage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionPage optionForm = new OptionPage();
            optionForm.novels = this.novels;

            

            optionForm.UpdateNovels += new OptionPage.NovelsHandler(novelsUpdate);

            //Display Form2
            optionForm.ShowDialog();


        }

        private void novelsUpdate(object s, UpdateNovelsEventsArgs e)
        {
            novels = e.GetNovels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }



        private void charB_Click(object sender, EventArgs e)
        {
            int nestedPointer = pointer;
            meh[pointer].Visible = true;

        }




}



}
