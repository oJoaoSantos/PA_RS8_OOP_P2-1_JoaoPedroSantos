using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            string option = Basics.ValidateChoice(menu);
            return option;
        }

    }
}
