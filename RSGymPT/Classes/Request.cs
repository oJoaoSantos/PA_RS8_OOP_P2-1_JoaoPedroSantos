using RSGymPT.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;
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

        public Request(int requestNumber, int numberOfRequests, int clientNumber, string ptCode, DateTime requestDateHours, string requestStatus)
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
        public List<Request> RequestSave(int requestNumber, int clientNumber, string ptCode, DateTime requestDateHours)
        {
            List<Request> Requests = new List<Request>();
            Requests.Add(NewRequest(requestNumber, clientNumber, ptCode, requestDateHours));
            return Requests;
        }
        #endregion

        #region Regist Request

        #region Ask Request
        public void AskPtCode()
        {            
            PersonalTrainer founded;
            string ptCodeReaded;

            Utilities.Basics.Title01("Pedido de Aula");
            do
            {
                Console.Write("Código do PT > ");
                ptCodeReaded = Console.ReadLine();
                founded = ValidatePt(ptCodeReaded);
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

        public void AskDateTime()
        {
            //string dateTimeReaded, hoursReaded;
            RequestDateHours = DateTime.MinValue;

            //Console.Write("Data e horas da sessão (dd.mm.aaaa.hh.mm) > ");
            //dateTimeReaded = Console.ReadLine();

            //RequestDateHours = Convert.ToDateTime(dateTimeReaded);

        }

        public Request NewRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestDateHours) // todo criar um array inicial com o tamanho do count do programcs para depois manipular.
        {
            Request newRequest = new Request { RequestNumber = requestNumber, ClientNumber = clientNumber, PtCode = ptCode, RequestDateHours = requestDateHours, RequestStatus = "Agendado" };
            return newRequest;
        }
        #endregion

        #endregion

        #region Show Requests

        public void ShowRequests(int requestNumber, int clientNumber, string ptCode, DateTime requestDateHours)
        {
            List<Request> Requests = RequestSave(requestNumber, clientNumber, ptCode, requestDateHours);

            foreach(Request rq in Requests)
            {
                Console.WriteLine($"{rq.RequestNumber}\t{rq.PtCode}\t{rq.RequestDateHours}\t{rq.RequestStatus}");
            }
        }

        #endregion

        #endregion

    }
}
