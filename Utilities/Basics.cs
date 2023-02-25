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

        public static void Header()
        {
            Console.WriteLine(" ____  ___                            ____  ____   ");
            Console.WriteLine("(  _ )( __)     ___  _  _  __  __    (  _ )(_  _)  ");
            Console.WriteLine(" )   )(__ )    ( __)( () )(  ()  )    ) __)  )(    ");
            Console.WriteLine("(_)(_)(___)   ( (_-. (  )  ) () (    (__)   (__)   ");
            Console.WriteLine("               (___) (__) (_)  (_)               \n");
            Console.WriteLine("A nova App! Gere aqui as tuas aulas personalizadas.");
        }

        public static void Title01(string title)
        {
            string message = "A nova App! Gere aqui as tuas aulas personalizadas.";
            Console.WriteLine(new string('_', message.Length));
            Console.WriteLine($"\n{title.ToUpper()}");
            Console.WriteLine(new string('_', message.Length));
        }

        public static void Title02(string title)
        {
            string message = "A nova App! Gere aqui as tuas aulas personalizadas.";
            Console.WriteLine(new string('_', message.Length));
            Console.WriteLine($"\n{title}");
            Console.WriteLine(new string('_', message.Length));
        }

        public static void Voltar()
        {
            Console.WriteLine("\n\nPrime qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void FinalMessage()
        {
            string message01 = "\nO RSGymPT agradece a tua visita.";
            string message02 = "\n\nPrime qualquer tecla para saíres.";
            Console.Clear();
            Header();
            Console.WriteLine(new string('_', message01.Length));
            Console.WriteLine(message01);
            Console.WriteLine(new string('_', message01.Length));
            Console.WriteLine(message02);
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

        public static DateTime AskData()
        {
            bool dateConvertedSuccess = false;
            string dateReaded;
            DateTime dateConverted;
            do
            {
                Console.Write("Data da Aula > ");
                dateReaded = Console.ReadLine();
                dateConvertedSuccess = DateTime.TryParse(dateReaded, out dateConverted);
            } while (dateConvertedSuccess == false || dateConverted < DateTime.Now); // Só permite marcar aulas para o dia seguinte.

            return dateConverted;
        }

        public static DateTime AskHours()
        {
            bool  hoursConvertedSuccess = false;
            string hoursReaded;
            DateTime hoursConverted;
            do
            {
                Console.Write("Horas da Aula > ");
                hoursReaded = Console.ReadLine();
                hoursConvertedSuccess = DateTime.TryParse(hoursReaded, out hoursConverted);
            } while (hoursConvertedSuccess == false);

            return hoursConverted;
        }
    }
}
