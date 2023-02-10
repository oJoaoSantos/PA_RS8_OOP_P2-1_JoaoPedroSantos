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
            RequestNumber = requestNumber;
            ClientNumber = clientNumber;
            PtCode = ptCode;
            RequestDateHours = requestDateHours;
            RequestStatus = requestStatus;
        }


        #endregion

        #region Methods

        #region Data Creation
        
        public Request[] CreateRequest()
        {
            Request[] requests = new Request[]
               {
                new Request { RequestNumber = 1, ClientNumber = 1, PtCode = "JPS", RequestDateHours = new DateTime(2023, 02, 01, 10, 00, 0), RequestStatus = "terminado" },
                new Request { RequestNumber = 2, ClientNumber = 2, PtCode = "MLS", RequestDateHours = new DateTime(2023, 02, 01, 10, 00, 0), RequestStatus = "terminado" }
               };
            return requests;
        }
        #endregion

        #region Show Requests

        public void ShowRequests()
        {
            Request[] requests = CreateRequest();
            string line = "\nPedido  |Cliente|PT     |Data                   |Horas  |Estado   ";
            Console.WriteLine(line);
            Console.WriteLine(new string('_', line.Length));

            for (int i = 0; i < requests.Length; i++)
            {
                Console.WriteLine($"\n{requests[i].RequestNumber.ToString("000")}\t|{requests[i].ClientNumber.ToString("000")}\t|{requests[i].PtCode}\t|{requests[i].RequestDateHours.ToLongDateString()}\t|{requests[i].RequestDateHours.ToShortTimeString()}\t|{requests[i].RequestStatus}");
                Console.WriteLine(new string('_', line.Length));
            }
        }

        #endregion

        #endregion

    }
}
