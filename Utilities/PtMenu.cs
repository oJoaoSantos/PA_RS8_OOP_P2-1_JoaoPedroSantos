using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
