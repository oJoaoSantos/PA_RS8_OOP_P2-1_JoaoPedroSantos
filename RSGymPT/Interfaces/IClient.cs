using RSGymPT.Classes;
using System;
using Utilities;

namespace RSGymPT.Interfaces
{
    internal interface IClient
    {
        #region Properties
        int ClientNumber { get; }
        string ClientName { get; }
        string ClientUserName { get; }
        string ClientPassword { get; }
        #endregion

        #region Methods
        Client[] CreateClient();
        void ReadCredentials();
        Client ValidateCredentials(Client client);
        void Login(string client);
        void Logout();
        void ShowClient();
        int FindClientNumber(Client client);
        #endregion
    }
}
