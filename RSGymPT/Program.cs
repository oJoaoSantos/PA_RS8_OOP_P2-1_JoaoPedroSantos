using RSGymPT.Classes;
using System;

// todo Títulos nos menus 
// todo formato de hora e data nos requests 
// todo mostrar os requests mais bonitos 
// todo Consultar Clientes 
// todo Interfaces
// todo Limpar os usings
// acrescentar as properties requeridas ao PT

namespace RSGymPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities.Basics.SetUniCodeConsole();

            #region Instantiate Objects
            Client client = new Client();
            PersonalTrainer personalTrainer01 = new PersonalTrainer();
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
                            validClient = client.ValidateCredentials(client);
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
                                                    request01.AskDataHours();
                                                    requestCount++;
                                                    request01.NewRequest(requestCount, client.FindClientNumber(client), request01.PtCode, request01.RequestHours, request01.RequestDate);
                                                    Console.Clear();
                                                    
                                                    Console.ReadKey();
                                                break;

                                                case "2":
                                                    Console.Clear();
                                                    request01.AskRequestNumberToAlter();
                                                    Console.Clear();
                                                    request01.AskPtCode();
                                                    request01.AskDataHours();
                                                    request01.AlterRequest(request01.RequestNumber, client.FindClientNumber(client), request01.PtCode, request01.RequestHours, request01.RequestDate);
                                                    Console.Clear();
                                                break;

                                                case "3":
                                                    Console.Clear();
                                                    request01.AskRequestNumberToDrop();
                                                    request01.DropRequest(request01.RequestNumber, client.FindClientNumber(client), request01.PtCode, request01.RequestHours, request01.RequestDate);
                                                    Console.Clear();
                                                break;

                                                case "4":
                                                    Console.Clear();
                                                    request01.ShowRequests();

                                                    Console.ReadKey();
                                                break;

                                                case "5":
                                                    Console.Clear();
                                                    request01.AskRequestNumberToTerminate();
                                                    request01.TerminateRequest(request01.RequestNumber, client.FindClientNumber(client), request01.PtCode, DateTime.Now, DateTime.Now);
                                                    Console.Clear();
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

                                        case "3":
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

                                        default:
                                            Console.Clear();
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
