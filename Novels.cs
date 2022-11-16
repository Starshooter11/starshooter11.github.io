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
    // novel page where user can view contents of a novel
    public partial class Novels : Form
    {
        List<Form> contents = new List<Form>();
        public Novels()
        {
            InitializeComponent();
        }

        private void Novelcs_Load(object sender, EventArgs e)
        {
            if (contents.Count == 0)
            {
                MessageBox.Show("This novel is currently empty!");
            }
        }
    }
}
