using WorkShop1.Interface;
using WorkShop1.Manager;

namespace WorkShop1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}
