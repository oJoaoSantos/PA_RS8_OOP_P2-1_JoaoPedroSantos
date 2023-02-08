using RSGymPT.Classes;
using System;
using System.Runtime.Remoting.Channels;
using Utilities;

namespace RSGymPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities.Basics.SetUniCodeConsole();

            #region Instantiate Objects
            Client client01 = new Client();
            #endregion

            #region Create and Declare Variables
            string loginChoice, navegationMenuChoice;
            #endregion

            #region Console Run

            #endregion
            loginChoice = Utilities.InitialMenu.Menu();
            if (loginChoice == "1")
            {
                Console.Clear();                //teste

                Console.WriteLine("Bem vindo"); // Substitui login

                Console.ReadKey();              //teste
                Console.Clear();                //teste

                navegationMenuChoice = Utilities.NavegationMenu.Menu();
                Console.Clear();                //teste
                switch (navegationMenuChoice)
                { 
                    case "1":
                        Utilities.RequestMenu.Menu();
                        //6 cases
                        break;
                    case "2":
                        //2 cases
                        break;
                    default:
                        //3 cases
                        break;
                }
                
                client01.Logout();
            }
            else 
            {
                Utilities.Basics.FinalMessage();
            }
        }
    }
}
