using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texttomeh2
{
    public partial class Plot : Form
    {
        public Plot()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
   
        }

        //currently fixing
        //private void CreateTextBoxDelegate(object sender, EventArgs e)
        //{
        //    TextBox newTB = new TextBox();
        //    this.Controls.Add(newTB);
        //    newTB.Text = "Created Button";
        //    newTB.Location = new Point(600, 300);
        //    newTB.Size = new Size(50, 100);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //currently fixing
            //TextBox newTB = new TextBox();
            //this.Controls.Add(newTB);
            //newTB.Text = "Created TB";
            //newTB.Location = new Point(700, 300);
            //newTB.Size = new Size(50, 100);
            ////newTB.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }




}
