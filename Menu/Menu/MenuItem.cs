using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class MenuItem
    {
        public string Title = " ";
        public string valg = "";
        public MenuItem(string itemTitle, string valg)
        {
            Title = itemTitle;
            this.valg = valg;

        }
    }
}
