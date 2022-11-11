using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texttomeh2.Events
{
    public class UpdateNovelsEventsArgs : EventArgs
    {
        private List<Form> novels = new List<Form>();

        public UpdateNovelsEventsArgs(List<Form> c)
        {
            novels = c;
        }

        public List<Form> GetNovels
        {
            get
            {
                return novels;
            }
        }
    }
}
