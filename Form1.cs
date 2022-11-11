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
        private int pointer = -1;
        private List<Form> meh = new List<Form>();

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

       public static void UpdateFormChar(Form2 form)
        {
            Button charB = new Button();
            charB.Location = new Point(12, 46);
            charB.Size = new Size(70, 80);
            charB.Text = "Character";
            charB.Name = "charB";
            meh.Add(form);
            charB.Click += new EventHandler(charB_Click);

            // Add Button to the Form. Placement of the Button  
            // will be based on the Location and Size of button  
            Controls.Add(charB);
            charB.BringToFront();

        }



        private void charB_Click(object sender, EventArgs e)
        {
            int nestedPointer = pointer;
            meh[pointer].Visible = true;

        }




}



}
