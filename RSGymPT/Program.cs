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
            Client client = new Client();
            PersonalTrainer personalTrainer01 = new PersonalTrainer("JPS", "João Pedro Loureiro Santos");
            PersonalTrainer personalTrainer02 = new PersonalTrainer("MSF", "Matilde Sousa Ferreira");
            PersonalTrainer personalTrainer03 = new PersonalTrainer("EST", "Érica Santos Teixeira");
            Request request01 = new Request();
            #endregion

            #region Create and Declare Variables
            string loginChoice, navegationMenuChoice, requestMenuChoice, requestPtMenu, requestClientMenu;
            bool endProgram = false;
            Client validClient = null;
            int requestCount = 0;
            #endregion

            #region Console Run
            
            
                
                do
                {
                    loginChoice = Utilities.InitialMenu.Menu();
                    switch (loginChoice)
                    {
                        case "1":
                            client.ReadCredentials();
                            validClient = client.ValidateCredentials(client); // todo atrinuir nome e numero ao cliente depois de validar
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
                                    client.Login(validClient.ClientName);
                                    navegationMenuChoice = Utilities.NavegationMenu.Menu();
                                    Console.Clear();
                                    switch (navegationMenuChoice)
                                    {
                                        case "1":
                                            requestMenuChoice = Utilities.RequestMenu.Menu();

                                            switch (requestMenuChoice)
                                            {
                                                case "1":
                                                Console.Clear();
                                                    request01.AskPtCode();
                                                    request01.AskDateTime();
                                                    requestCount++;
                                                    request01.NewRequest(requestCount, 1, request01.PtCode, request01.RequestDateHours);
                                                    request01.RequestSave(requestCount, 1, request01.PtCode, request01.RequestDateHours);
                                                    Console.Clear();
                                                    
                                                    Console.ReadKey();
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
                                                    request01.ShowRequests(requestCount, 1, request01.PtCode, request01.RequestDateHours);

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
                                client.Logout();

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
