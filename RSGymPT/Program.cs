using RSGymPT.Classes;
using System;


// se não houver pedidos, imprime que não há pedidos.

namespace RSGymPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities.Basics.SetUniCodeConsole();
            try
            {
                #region Instantiate Objects
                Client client = new Client();
                Clients clients = new Clients();
                PersonalTrainers personalTrainers = new PersonalTrainers();
                Requests requests = new Requests();
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
                                                    Utilities.Basics.Title01("Faz aqui o teu novo pedido");
                                                    string ptCode = personalTrainers.AskPtCode();
                                                    DateTime date = Utilities.Basics.AskData();
                                                    DateTime hours = Utilities.Basics.AskHours();

                                                    requests.NewRequest(client.FindClientNumber(client), ptCode, date, hours);
                                                    Utilities.Basics.Title02("Agendaste uma aula nova");
                                                    Utilities.Basics.Voltar();
                                                    break;

                                                case "2":
                                                    Console.Clear();
                                                    Utilities.Basics.Title01("Altera um pedido");
                                                    int requestNumberAlter = requests.AskRequestNumber();
                                                    if (requestNumberAlter > 0)
                                                    {
                                                        Console.Clear();
                                                        string ptCode1 = personalTrainers.AskPtCode();
                                                        DateTime date1 = Utilities.Basics.AskData();
                                                        DateTime hours1 = Utilities.Basics.AskHours();
                                                        requests.AlterRequest(requestNumberAlter, client.FindClientNumber(client), ptCode1, hours1, date1);
                                                        Utilities.Basics.Title02($"Alteraste o pedido número {requestNumberAlter}.");
                                                        Utilities.Basics.Voltar();
                                                    }
                                                    else
                                                    {
                                                        Utilities.Basics.Title02("Número de pedido inválido.");
                                                        Utilities.Basics.Voltar();
                                                    }

                                                    break;

                                                case "3":
                                                    Console.Clear();
                                                    Utilities.Basics.Title01("Elimina um pedido");
                                                    int requestNumberDrop = requests.AskRequestNumber();
                                                    if (requestNumberDrop > 0)
                                                    {
                                                        requests.DropRequest(requestNumberDrop);
                                                        Utilities.Basics.Title02($"Eliminaste o pedido número {requestNumberDrop}.");
                                                    }
                                                    else
                                                    {
                                                        Utilities.Basics.Title02("Número de pedido inválido.");
                                                    }
                                                    Utilities.Basics.Voltar();
                                                    break;

                                                case "4":
                                                    Console.Clear();
                                                    requests.ShowRequests();
                                                    Utilities.Basics.Voltar();
                                                    break;

                                                case "5":
                                                    Console.Clear();
                                                    Utilities.Basics.Title01("Termina a tua aula");
                                                    int requestNumberTerminate = requests.AskRequestNumber();
                                                    if (requestNumberTerminate > 0)
                                                    {
                                                        requests.TerminateRequest(requestNumberTerminate);
                                                        Utilities.Basics.Title02($"Aula {requestNumberTerminate} terminada pelas {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}.");
                                                    }
                                                    else
                                                    {
                                                        Utilities.Basics.Title02("Número de pedido inválido.");
                                                    }
                                                    Utilities.Basics.Voltar();
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
                                                    personalTrainers.ShowPt();
                                                    Utilities.Basics.Voltar();
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
                                                    Console.Clear();
                                                    clients.ShowClient();
                                                    Utilities.Basics.Voltar();
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
            catch (Exception)
            {
                Console.WriteLine("Aconteceu um erro.");
                throw;
            }
        }
    }
}
