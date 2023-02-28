using System;
using System.Runtime.Remoting.Messaging;
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
            string message = "Número: 1       PT: EST         Data: 10 de outubro de 2023     Horas: 10:00    Estado: Terminado 28/02/2023 23:48";
            string header = " ____  ___                            ____  ____   ";
            Console.SetCursorPosition((message.Length - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(" ____  ___                            ____  ____   ");
            Console.SetCursorPosition((message.Length - header.Length) / 2, Console.CursorTop);
            Console.WriteLine("(  _ )( __)     ___  _  _  __  __    (  _ )(_  _)  ");
            Console.SetCursorPosition((message.Length - header.Length) / 2, Console.CursorTop);
            Console.WriteLine(" )   )(__ )    ( __)( () )(  ()  )    ) __)  )(    ");
            Console.SetCursorPosition((message.Length - header.Length) / 2, Console.CursorTop);
            Console.WriteLine("(_)(_)(___)   ( (_-. (  )  ) () (    (__)   (__)   ");
            Console.SetCursorPosition((message.Length - header.Length) / 2, Console.CursorTop);
            Console.WriteLine("               (___) (__) (_)  (_)               \n");
            Console.SetCursorPosition((message.Length - header.Length) / 2, Console.CursorTop);
            Console.WriteLine("A nova App! Gere aqui as tuas aulas personalizadas.");
        }

        public static void Title01(string title)
        {
            string message = "Número: 1       PT: EST         Data: 10 de outubro de 2023     Horas: 10:00    Estado: Terminado 00/0/0000 00:00";
            Console.WriteLine(new string('_', message.Length));
            Console.WriteLine();
            Console.SetCursorPosition((message.Length - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title.ToUpper());
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
            string message01 = "O RSGymPT agradece a tua visita.";
            string message02 = "\n\nPrime qualquer tecla para saíres.";
           
            Console.Clear();
            Header();
            Title01(message01);
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
            bool hoursConvertedSuccess = false;
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
