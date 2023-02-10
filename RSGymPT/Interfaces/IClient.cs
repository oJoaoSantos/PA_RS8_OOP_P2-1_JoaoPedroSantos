using System;
using Utilities;

namespace RSGymPT.Interfaces
{
    internal interface IClient
    {
        #region Properties
        string ClientCode { get; }
        string ClientName { get; }
        string ClientUserName { get; }
        string ClientPassword { get; }
        #endregion

        #region Methods
        void Login(string client);
        void Logout();
        #endregion
    }
}
