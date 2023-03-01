using System;

namespace Utilities
{
    public class ClientMenu
    {
        public static string Menu()
        {
            string[] menu =
            {
               "Consultar  > 1",
               "   Voltar  > 2",
               "  Logout   > 3"
            };

            Basics.Header();
            Basics.Title01("Menu do utilizador");
            Console.WriteLine();

            Console.WriteLine();
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            string option = Basics.ValidateChoice(menu);
            return option;
        }
    }
}
