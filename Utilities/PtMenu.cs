using System;

namespace Utilities
{
    public class PtMenu
    {
        public static string Menu()
        {
            string[] menu =
            {
               "Consultar  > 1",
               "   Voltar  > 2"
            };

            Basics.Header();
            Basics.Title01("Personal Trainers");
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
