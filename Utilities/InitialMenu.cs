using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class InitialMenu
    {
        public static string Menu()
        {
            string[] menu =
            {
               " Entrar  > 1",
               "   Sair  > 2"
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
