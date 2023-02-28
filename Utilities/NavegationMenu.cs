using System;


namespace Utilities
{
    public class NavegationMenu
    {
        public static string Menu()
        {
            string[] menu =
            {
               "          Pedido  > 1",
               "Personal Trainer  > 2",
               "      Utilizador  > 3"
            };

            Utilities.Basics.Header();
            Utilities.Basics.Title01("Menu Inicial");
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
