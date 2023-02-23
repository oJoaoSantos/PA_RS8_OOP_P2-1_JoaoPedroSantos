using RSGymPT.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Utilities;

namespace RSGymPT.Classes
{

    internal class Request : IRequest
    {
        #region Atributes
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
            RequestNumber = 0;
            ClientNumber = 0;
            PtCode = string.Empty;
            RequestDate = DateTime.MinValue;
            RequestHours = DateTime.MinValue;
            RequestStatus = string.Empty;
        }

        public Request(int requestNumber, int numberOfRequests, int clientNumber, string ptCode, DateTime requestDate, DateTime requestHours, string requestStatus)
        {
            RequestNumber = requestNumber;
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

        public void AskDataHours()
        {
            bool dateConvertedSuccess = false, hoursConvertedSuccess = false;
            string dateReaded, hoursReaded;
            DateTime dateConverted, hoursConverted;
            do
            {
                Console.Write("Data da Aula > ");
                dateReaded = Console.ReadLine();
                dateConvertedSuccess = DateTime.TryParse(dateReaded, out dateConverted);
            } while (dateConvertedSuccess == false || dateConverted < DateTime.Now); // Só permite marcar aulas para o dia seguinte.
            do
            {
                Console.Write("Horas da Aula > ");
                hoursReaded = Console.ReadLine();
                hoursConvertedSuccess = DateTime.TryParse(hoursReaded, out hoursConverted);
            } while (hoursConvertedSuccess == false);

            RequestDate = dateConverted;
            RequestHours = hoursConverted;
        }
        #endregion

        #region Save New Requests Data
        public void NewRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate)
        {
            requestsData.Add( new Request { RequestNumber = requestNumber, ClientNumber = clientNumber, PtCode = ptCode, RequestHours = requestHours, RequestDate = requestDate, RequestStatus = "Agendado" });
        }
        #endregion

        #endregion

        #region Alter Request

        public void AskRequestNumberToAlter()
        {
            Console.Write("Número de Pedido a alterar > ");
            string requestNumberReaded = Console.ReadLine();
            Request finded = requestsData.Find(element => element.Equals(requestNumberReaded) && element.Equals("Agendado"));
            //if (finded != null)
            //{
                RequestNumber = int.Parse(requestNumberReaded);
            //};
        }

        public void AlterRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate)
        {
            requestsData.RemoveAt(requestNumber - 1);
            requestsData.Insert(requestNumber-1, new Request { RequestNumber = requestNumber, ClientNumber = clientNumber, PtCode = ptCode, RequestHours = requestHours, RequestDate = requestDate, RequestStatus = "Agendado" });
        }

        #endregion

        #region Show Requests

        public void ShowRequests()
        {
            foreach(Request rq in requestsData)
            {
                Console.WriteLine($"{rq.RequestNumber}\t{rq.PtCode}\t{rq.RequestDate}\t{rq.RequestHours}\t{rq.RequestStatus}");
            }
        }

        #endregion

        #endregion

    }
}
