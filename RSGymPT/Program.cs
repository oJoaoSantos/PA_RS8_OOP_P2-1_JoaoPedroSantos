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
            Request request01 = new Request();
            #endregion

            #region Create and Declare Variables
            string loginChoice, navegationMenuChoice, requestMenuChoice, requestPtMenu, requestClientMenu;
            bool endProgram = false;
            Client validClient = null;
            #endregion

            #region Console Run
            
            
                
                do
                {
                    loginChoice = Utilities.InitialMenu.Menu();
                    switch (loginChoice)
                    {
                        case "1":
                            client01.ReadCredentials();
                            validClient = client01.ValidateCredentials(client01);
                            if (validClient == null)
                            {
                                Console.WriteLine("Username ou password incorretos");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
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
                                                    Console.Clear();
                                                    request01.ShowRequests();
                                                    Console.ReadKey();
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
                            break;

                            case "2":
                                Utilities.Basics.FinalMessage();
                                break;

                            default:
                                Console.Clear();
                            break;
                    }
                } while (validClient == null && loginChoice != "2");

                
            
                #endregion
        }
    }
}
