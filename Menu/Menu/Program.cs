namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            do
            {
                 
                Menu mainMenu = new Menu("Min fantastiske menu");
                mainMenu.AddMenuItem("1. Gør dit", "gør dit");
                mainMenu.AddMenuItem("2. Gør dat", "gør dat");
                mainMenu.AddMenuItem("3. noget", "gør noget");
                mainMenu.AddMenuItem("4. pølser", "Mammenam");
                mainMenu.AddMenuItem("vælg fra 1 til 4", " ");
                mainMenu.Show();

                mainMenu.SelectMenuItem();
                

                Console.ReadLine();
                Console.Clear();
            } while (Console.ReadLine() != "0");            
        }
    }
    




}
