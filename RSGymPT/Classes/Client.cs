using RSGymPT.Interfaces;
using System;
using Utilities;

namespace RSGymPT.Classes
{
    internal class Client : IClient
    {
        #region Properties
        public int ClientNumber { get; set; }
        public string ClientName { get; set; }
        public string ClientUserName { get; set; }
        public string ClientPassword { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods

        #region Data Creation
        public static int AutoIncrement(int actual = 1)
        {
            actual = actual++;
            return actual;
        }
        public Client[] CreateClient()
        {
            Client[] clients = new Client[]
               {
                new Client { ClientNumber = 1, ClientName = "Palmira Loureiro", ClientUserName = "palmira", ClientPassword = "Palmira123" },
                new Client { ClientNumber = 2, ClientName = "António Duarte", ClientUserName = "antonio", ClientPassword = "Antonio123" }
               };
            return clients;
        }
        #endregion

        #region Login

        #region ReadCredentials
        public void ReadCredentials()
        {
            Console.Clear();
            Utilities.Basics.Header();
            Utilities.Basics.Title01("Login");
            Console.Write("Username  > ");
            ClientUserName = Console.ReadLine();

            Console.Write("Password  > ");
            ClientPassword = Console.ReadLine();
        }
        #endregion

        #region ValidateCredentials
        public Client ValidateCredentials(Client client)
        {
            Client[] clients = client.CreateClient();
            Client validClient = Array.Find(clients, clt => clt.ClientUserName.ToLower() == client.ClientUserName.ToLower() && clt.ClientPassword == client.ClientPassword);
            return validClient;
        }
        #endregion

        #region Login Method
        public void Login(string client)
        {
            Console.Clear();
            Utilities.Basics.Title01($"Bem vindo/a à RSGymPT App {client}!");
        }
        #endregion

        #endregion

        #region Logout
        public void Logout()
        {
            Utilities.Basics.FinalMessage();
        }
        #endregion

        #region Find ClientNumber
        public int FindClientNumber(Client client)
        {
            Client[] clients = CreateClient();
            int clientNumber = Array.IndexOf(clients, client.ClientUserName)+1;
            return clientNumber;
        }
        #endregion

        #endregion

    }
}