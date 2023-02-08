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
        public static void WriteTXT(Form form, string file)
        {

            List<String> lines = new List<String>();
            lines.Add("Name: " + form.Name);

            Control[] controlArray = new Control[form.Controls.Count];

            form.Controls.CopyTo(controlArray, 0);
            

            int length = controlArray.Length;
            
            for(int a = length-1 ; a > -1 ; a--)
            {
                  for(int b = length-1; b> -1; b--)
                  {
                      if((controlArray[a].Name.Contains(controlArray[b].Name)) && (controlArray[a] != controlArray[b]) && !(controlArray[a].Name.Contains("progCre")))
                      {
                          lines.Add(controlArray[b].Text + ": " + controlArray[a].Text);
                      }
                  }
            }
             
            

            for (int n = length-1; n > -1; n--)
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

            DialogResult dr = MessageBox.Show(temp + "\n\n\nIs this correct?", "Please click yes to export or no to cancel", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    File.WriteAllLines(file, lines);
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelling Export of card.");
                    break;
            }

            
        }
    }
}
