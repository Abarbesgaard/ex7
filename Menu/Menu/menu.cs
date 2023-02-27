using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Menu
    {
        public string Title;
        private MenuItem[] menuItems;
        private int itemCount;
        string userInput;
        bool success = false;
        int result; 

        public Menu(string MenuTitle)
        {
            Title = MenuTitle;
            menuItems = new MenuItem[10];
            itemCount = 0;


        }
        public void AddMenuItem(string menuTitle, string valg)
        {
            MenuItem mi = new MenuItem(menuTitle, valg);
            menuItems[itemCount] = mi;
            itemCount++;
        }
        public int SelectMenuItem()
        {
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out result) == true)
            {
                Console.WriteLine("ja man");
            }
            else 
            {
                Console.WriteLine("sovs");
            }

            Console.WriteLine(menuItems[result - 1].valg);
            return result; 
        }
        public void Show()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }
        }
    }
}
