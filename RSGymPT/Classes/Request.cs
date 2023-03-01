using RSGymPT.Interfaces;
using System;
using System.Collections.Generic;


namespace RSGymPT.Classes
{

    internal class Request : IRequest
    {
        #region Class Variables
        static int autoReqId = 0;
        private List<Request> requestsData = new List<Request>();
        #endregion

        #region Properties
        public int RequestNumber { get; set; }
        public int ClientNumber { get; set; }
        public string PtCode { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime RequestHours { get; set; }
        public string RequestStatus { get; set; }
        #endregion

        #region Constructors
        public Request()
        {
            RequestNumber = autoReqId++;
            ClientNumber = 0;
            PtCode = string.Empty;
            RequestDate = DateTime.MinValue;
            RequestHours = DateTime.MinValue;
            RequestStatus = string.Empty;
        }

        public Request(int numberOfRequests, int clientNumber, string ptCode, DateTime requestDate, DateTime requestHours, string requestStatus)
        {
            RequestNumber = autoReqId++;
            ClientNumber = clientNumber;
            PtCode = ptCode;
            RequestDate = requestDate;
            RequestHours = requestHours;
            RequestStatus = requestStatus;
        }

        #endregion

        #region Methods

        #region Ask Request Number
        public int AskRequestNumber()
        {
            Request finded;
            string requestNumberReaded;
            Console.Write("Número de Pedido a alterar > ");
            requestNumberReaded = Console.ReadLine();
            finded = requestsData.Find(element => element.RequestNumber.Equals(int.Parse(requestNumberReaded)) && element.RequestStatus.Equals("Agendado"));
            if (finded != null)
            {
                return int.Parse(requestNumberReaded);
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Alter Request
        public void AlterRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate)
        {
            Request request = requestsData.Find(element => element.RequestNumber.Equals(requestNumber));
            request.ClientNumber = clientNumber;
            request.PtCode = ptCode;
            request.RequestHours = requestHours;
            request.RequestDate = requestDate;
        }
        #endregion

        #region Drop Request
        public void DropRequest(int requestNumber)
        {
            requestsData.RemoveAt(requestsData.FindIndex(element => element.RequestNumber.Equals(requestNumber)));
        }
        #endregion

        #region Save New Requests Data
        public void NewRequest(int clientNumber, string ptCode, DateTime date, DateTime hours)
        {
            requestsData.Add(new Request { ClientNumber = clientNumber, PtCode = ptCode, RequestHours = hours, RequestDate = date, RequestStatus = "Agendado" });
        }
        #endregion

        #region Terminate Request
        public void ShowTerminateRequest()
        {
            DateTime now = DateTime.Now;
            RequestStatus = $"Terminado {now.ToShortDateString()} {now.ToShortTimeString()}";
        }
        public void TerminateRequest(int requestNumber)
        {
            Request finded;
            finded = requestsData.Find(element => element.RequestNumber.Equals(requestNumber));
            finded.ShowTerminateRequest();
        }
        #endregion

        #region Cancel Request
        
        public void CancelRequest(int requestNumber)
        {
            Request finded;
            finded = requestsData.Find(element => element.RequestNumber.Equals(requestNumber));
            finded.RequestStatus = $"Cancelado";
        }
        #endregion

        #region Show Requests 
        public void ShowRequests()
        {
            Utilities.Basics.Title01("Lista de Pedidos");

            if (requestsData.Count < 1)
            {
                Utilities.Basics.Title02("Não existem pedidos para mostrar.\nRegista o teu primeiro pedido!");
            }
            else
            {
                foreach (Request rq in requestsData)
                {
                    Console.WriteLine($"\n\nNúmero: {rq.RequestNumber}\tPT: {rq.PtCode}\t\tData: {rq.RequestDate.ToLongDateString()}\tHoras: {rq.RequestHours.ToShortTimeString()}\tEstado: {rq.RequestStatus}");
                }
            }

        }
        #endregion

        #endregion
    }
}
