using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Texttomeh2.Events
{
    public class ExportTXT
    {
        public static void WriteTXT(Form a, string d)
        {

            List<String> lines = new List<String>();
            lines.Add("Name: " + a.Name);

            Control[] controlArray = new Control[a.Controls.Count];

            a.Controls.CopyTo(controlArray, 0);

            foreach (Control b in controlArray)
            {
                foreach (Control c in controlArray)
                {
                    if( (c.Name.Contains(b.Name)) && (c != b) && !(c.Name.Contains("progCre")))
                    {
                        lines.Add(b.Text + ": " + c.Text);
                    }
                }
            }
            
            for (int n = 0; n < controlArray.Length-1; n++)
            {
                if(controlArray[n].Name.Contains("progCreLB"))
                {
                    lines.Add(controlArray[n].Text + ": " + controlArray[n+1].Text);
                }
            }

            String temp = "";
            foreach (string s in lines)
            {
                temp = temp + s + "\n";
            }

            MessageBox.Show(temp);

            File.WriteAllLines(d, lines);
        }
    }
}
