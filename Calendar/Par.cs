using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Par
    {
        public string Name { get; set;}
        public string Path { get; set;}
        public bool Selected { get; set;}
        public static List<Par> pars = new List<Par>();
        public Par(string name, string path, bool selected)
        {
            this.Name = name;
            this.Path = path;
            this.Selected = selected;
        }
    }
}
