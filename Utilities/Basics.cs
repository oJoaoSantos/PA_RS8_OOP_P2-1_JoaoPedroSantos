using System;
using System.Text;

namespace Utilities
{
    public class Basics
    {
        public static void SetUniCodeConsole()
        {
            Console.OutputEncoding = Encoding.UTF8; 
        }

        public static void FinalMessage()
        {
            Console.Write("O RSGymPT agradece a tua viita.\n\nPrime qualquer tecla para saíres.");
            Console.ReadKey();
        }

        public static string ValidateChoice(string[] menu)
        {
            string option, founded;
            do
            {
                Console.Write("\nEscolha  > ");
                option = Console.ReadLine();
                founded = Array.Find(menu, element => element.EndsWith(option));
            } while (founded == null);
            return option;
        }

    }
}
