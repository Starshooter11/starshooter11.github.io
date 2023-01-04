using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texttomeh2.Events
{
    public class UpdateCardsEventsArgs : EventArgs
    {
        private Dictionary<int, Form> cards = new Dictionary<int, Form>();

        public UpdateCardsEventsArgs(Dictionary<int, Form> c)
        {
            cards = c;
        }

        public Dictionary<int, Form> GetCards
        {
            get
            {
                return cards;
            }
        }
    }
}
