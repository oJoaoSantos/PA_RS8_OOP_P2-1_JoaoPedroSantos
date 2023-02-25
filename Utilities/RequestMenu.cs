using System;

namespace Utilities
{
    public class RequestMenu
    {
        public static string Menu()
        {
            string[] menu =
            {
               " Registar  > 1",
               "  Alterar  > 2",
               " Eliminar  > 3",
               "Consultar  > 4",
               " Terminar  > 5",
               "   Voltar  > 6"
            };

            Basics.Header();
            Basics.Title01("menu de pedidos");
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
