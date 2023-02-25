using RSGymPT.Interfaces;
using System;

namespace RSGymPT.Classes
{
    internal class Clients : IClients
    {
        #region Class Variables and Data
        static int autoClientId = 1;
        Client[] clients = new Client[]
        {
        new Client { ClientNumber = autoClientId++, ClientName = "Palmira Loureiro", ClientUserName = "palmira", ClientPassword = "Palmira123" },
        new Client { ClientNumber = autoClientId++, ClientName = "António Duarte", ClientUserName = "antonio", ClientPassword = "Antonio123" },
        };
        #endregion

        #region Methods

        #region Show Client
        public void ShowClient()
        {

            Utilities.Basics.Title01("Lista de Clientes");

            for (int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine($"\n\nNúmero: {clients[i].ClientNumber}\tNome: {clients[i].ClientName}\t\tUserName: {clients[i].ClientUserName}");
            }
        }
        #endregion

        #endregion

    }
}