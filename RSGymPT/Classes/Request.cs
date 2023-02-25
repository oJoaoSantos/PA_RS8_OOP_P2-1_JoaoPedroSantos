using RSGymPT.Interfaces;
using System;
using System.Collections.Generic;


namespace RSGymPT.Classes
{

    internal class Request :IRequest
    {
        static int autoReqId = 1;

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

        #region Regist Request

        #region Ask Request
        public void AskPtCode()
        {
            PersonalTrainer founded;
            string ptCodeReaded;
            do
            {
                Console.Write("Código do PT > ");
                ptCodeReaded = Console.ReadLine();
                founded = ValidatePt(ptCodeReaded.ToUpper());
            } while (founded == null);
            PtCode = ptCodeReaded;
        }
        public PersonalTrainer ValidatePt(string ptCodeReaded)
        {
            PersonalTrainer pt = new PersonalTrainer();
            PersonalTrainer[] personaltrainers = pt.CreatePt();
            PersonalTrainer founded;

            founded = Array.Find(personaltrainers, element => element.PtCode == ptCodeReaded);
            return founded;
        }
        #endregion
        #endregion

        #region Ask Request Number
        public void AskRequestNumber()
        {
            Request finded = null;
            string requestNumberReaded;
            Console.Write("Número de Pedido a alterar > ");
            requestNumberReaded = Console.ReadLine();
            if (finded != null)
            {
                RequestNumber = int.Parse(requestNumberReaded);
            }
            else
            {
                RequestNumber = 0;
            }
        }
        #endregion

        #region Terminate Request
        public void TerminateRequest()
        {
            DateTime now = DateTime.Now;
            RequestStatus = $"Terminado {now.ToShortDateString()} {now.ToShortTimeString()}";
        }
        #endregion

        #endregion

    }
}
