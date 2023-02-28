using System;

namespace RSGymPT.Interfaces
{
    internal interface IRequest
    {
        #region Properties
        int RequestNumber { get; }
        int ClientNumber { get; }
        string PtCode { get; }
        DateTime RequestDate { get; }
        DateTime RequestHours { get; }
        string RequestStatus { get; }
        #endregion

        #region Methods

        #region Ask Request Number
        int AskRequestNumber();
        #endregion

        #region Alter Request
        void AlterRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate);
        #endregion

        #region Drop Request
        void DropRequest(int requestNumber);
        #endregion

        #region Save New Requests Data
        void NewRequest(int clientNumber, string ptCode, DateTime date, DateTime hours);
        #endregion

        #region Terminate Request
        void ShowTerminateRequest();
        void TerminateRequest(int requestNumber);
        #endregion

        #region Show Requests 
        void ShowRequests();
        #endregion

        #endregion

    }
}
