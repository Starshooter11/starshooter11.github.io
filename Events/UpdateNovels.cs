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
        private Dictionary<int,Form> novels = new Dictionary<int,Form>();

        public UpdateNovelsEventsArgs(Dictionary<int,Form> c)
        {
            novels = c;
        }

        public Dictionary<int,Form> GetNovels
        {
            get
            {
                return novels;
            }
        }
    }
}
