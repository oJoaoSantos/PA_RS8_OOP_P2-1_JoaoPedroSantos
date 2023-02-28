using RSGymPT.Classes;

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

        #region Data Creation
        void CreateClient();
        #endregion

        #region Login
        #region ReadCredentials
        void ReadCredentials();
        #endregion
        #region ValidateCredentials
        Client ValidateCredentials(Client client);
        #endregion
        #region Login Method
        void Login(string client);
        #endregion
        #endregion

        #region Logout
        void Logout();
        #endregion

        #region Find ClientNumber
        int FindClientNumber(Client client);
        #endregion

        #region Show Client
        void ShowClient();
        #endregion

        #endregion
    }
}
