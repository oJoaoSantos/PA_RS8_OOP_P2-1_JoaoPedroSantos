using System;

namespace Utilities
{
    public class Cancel
    {
        public static string Menu()
        {
            string[] menu =
            {
               " Alterar  > 1",
               "Cancelar  > 2",
               "  Voltar  > 3"
            };

            Console.WriteLine("\n");

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
