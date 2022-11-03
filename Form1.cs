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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 optionForm = new Form3();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        public void CreateTextBoxDelegate()
        {
            TextBox newTB = new TextBox();
            this.Controls.Add(newTB);
            newTB.Text = "Created Button";
            newTB.Location = new Point(600, 300);
            newTB.Size = new Size(50, 100);
        }

        

        


    }



}
