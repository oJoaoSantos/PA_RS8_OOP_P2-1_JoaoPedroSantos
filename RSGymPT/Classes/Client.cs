using RSGymPT.Interfaces;
using System;
using Utilities;

namespace RSGymPT.Classes
{
    internal class Client : IClient
    {
        #region Properties
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientUserName { get; set; }
        public string ClientPassword { get; set; }
        #endregion

        #region Methods
        public void Login()
        {



        }

        public void Logout()
        {
            Utilities.Basics.FinalMessage();
        }
        #endregion

    }
}
