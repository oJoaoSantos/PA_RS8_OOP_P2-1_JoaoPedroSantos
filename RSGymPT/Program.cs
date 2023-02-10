using Microsoft.Win32;
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
            PersonalTrainer personalTrainer01 = new PersonalTrainer();
            #endregion

            #region Create and Declare Variables
            string loginChoice, navegationMenuChoice, requestMenuChoice, requestPtMenu, requestClientMenu;
            bool endProgram = false;
            Client validClient;
            #endregion

            #region Console Run
            Utilities.Basics.Header();
            Utilities.Basics.Title01("Vamos lá?");
            loginChoice = Utilities.InitialMenu.Menu();
            if (loginChoice == "1")
            {
                Console.Clear();
                do
                {
                    Utilities.Basics.Header();
                    client01.ReadCredentials();
                    validClient = client01.ValidateCredentials(client01);
                    if (validClient == null)
                    {
                        Console.WriteLine("Username ou password incorretos, tenta de novo.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (validClient == null);

                while (endProgram == false)
                {
                    Utilities.Basics.Header();
                    client01.Login(validClient.ClientName);
                    navegationMenuChoice = Utilities.NavegationMenu.Menu();
                    Console.Clear();
                    switch (navegationMenuChoice)
                    {
                        case "1":
                            requestMenuChoice = Utilities.RequestMenu.Menu();

                            switch (requestMenuChoice)
                            {
                                case "1":
                                    Console.ReadKey();
                                    // Registar
                                    break;
                                case "2":
                                    Console.ReadKey();
                                    // Alterar
                                    break;
                                case "3":
                                    Console.ReadKey();
                                    // Eliminar
                                    break;
                                case "4":
                                    Console.ReadKey();
                                    // Consultar
                                    break;
                                case "5":
                                    Console.ReadKey();
                                    // Terminar
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                            break;

                        case "2":
                            requestPtMenu = Utilities.PtMenu.Menu();
                            switch (requestPtMenu)
                            {
                                case "1":
                                    Console.Clear();
                                    personalTrainer01.ShowPt();
                                    Console.ReadKey();
                                    
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                            break;

                        default:
                            requestClientMenu = Utilities.ClientMenu.Menu();
                            switch (requestClientMenu)
                            {
                                case "1":
                                    Console.ReadKey();
                                    // Consultar
                                    break;
                                case "2":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    endProgram = true;
                                    break;
                            }
                            break;
                    }
                }
                client01.Logout();
            }
            else 
            {
                Utilities.Basics.FinalMessage();
            }
            #endregion
        }
    }
}
