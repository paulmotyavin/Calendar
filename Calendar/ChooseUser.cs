using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Calendar
{
    public class ChooseUser
    {
        public DateTime date { get; set; }
        public List<Par> pars { get; set; }
        public static List<ChooseUser> users = new List<ChooseUser> { };

        public ChooseUser(DateTime date, List<Par> list) {
            this.date = date;
            this.pars = list;
        }
    }
}
