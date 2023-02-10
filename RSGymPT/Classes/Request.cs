using RSGymPT.Interfaces;
using System;
using Utilities;

namespace RSGymPT.Classes
{
    internal class Request : IRequest
    {
        #region Properties
        public int RequestNumber { get; set; }
        public int ClientNumber { get; set; }
        public string PtCode { get; set; }
        public DateTime RequestDateHours { get; set; }
        public string RequestStatus { get; set; }
        #endregion

        #region Constructors
        public Request()
        { 
            RequestNumber = 0;
            ClientNumber = 0;
            PtCode= string.Empty;
            RequestDateHours = DateTime.MinValue;
            RequestStatus = string.Empty;
        }

        public Request(int requestNumber, int clientNumber, string ptCode, DateTime requestDateHours, string requestStatus)
        {
            RequestNumber = requestNumber++;
            ClientNumber = clientNumber;
            PtCode = ptCode;
            RequestDateHours = requestDateHours;
            RequestStatus = requestStatus;
        }


        #endregion

        #region Methods

        #endregion

    }
}
