using RSGymPT.Interfaces;
using System;
using System.Collections.Generic;


namespace RSGymPT.Classes
{

    internal class Requests : IRequests
    {
        #region Class Data
        private List<Request> requestsData = new List<Request>();
        #endregion

        #region Methods

        #region Regist Request

        #region Ask Request

        public PersonalTrainer ValidatePt(string ptCodeReaded)
        {
            PersonalTrainer pt = new PersonalTrainer();
            PersonalTrainer[] personaltrainers = pt.CreatePt();
            PersonalTrainer founded;

            founded = Array.Find(personaltrainers, element => element.PtCode == ptCodeReaded);
            return founded;
        }
        #endregion

        #region Save New Requests Data
        public void NewRequest(int clientNumber, string ptCode, DateTime date, DateTime hours)
        {
            requestsData.Add(new Request { ClientNumber = clientNumber, PtCode = ptCode, RequestHours = hours, RequestDate = date, RequestStatus = "Agendado" });
        }
        #endregion
        #endregion

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

        #region Terminate Request
        public void TerminateRequest(int requestNumber)
        {
            Request finded;
            finded = requestsData.Find(element => element.RequestNumber.Equals(requestNumber));
            finded.TerminateRequest();
        }
        #endregion

        #region Show Requests 

        public void ShowRequests()
        {
            Utilities.Basics.Title01("Lista de Pedidos");

            foreach (Request rq in requestsData)
            {
                Console.WriteLine($"\n\nNúmero: {rq.RequestNumber}\tPT: {rq.PtCode}\tData: {rq.RequestDate.ToLongDateString()}\tHoras: {rq.RequestHours.ToShortTimeString()}\tEstado: {rq.RequestStatus}");
            }
        }
        #endregion
        #endregion

    }
}
