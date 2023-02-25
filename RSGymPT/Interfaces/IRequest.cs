using System;
using Utilities;

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
        void AskPtCode();
        PersonalTrainer ValidatePt(string ptCodeReaded);
        void AskDataHours();
        void NewRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate);
        void AskRequestNumber();
        void AlterRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate);
        void DropRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate);
        void TerminateRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate);
        void ShowRequests();
        #endregion

    }
}
