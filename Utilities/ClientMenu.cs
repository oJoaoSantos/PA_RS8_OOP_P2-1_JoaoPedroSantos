using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
               "  Logoout  > 3"
            };

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
