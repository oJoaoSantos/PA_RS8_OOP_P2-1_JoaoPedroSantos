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
        public string[,] Request() // todo criar um array inicial com o tamalho do count do programcs para depois manipular.
        {

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

        public void AskDateTime(Client client, int number)
        {
            //string dateTimeReaded, hoursReaded;
            RequestDateHours = DateTime.MinValue;

            //Console.Write("Data e horas da sessão (dd.mm.aaaa.hh.mm) > ");
            //dateTimeReaded = Console.ReadLine();

            //RequestDateHours = Convert.ToDateTime(dateTimeReaded);
            RequestStatus = "Agendado";
            ClientNumber = client.ClientNumber;
            RequestNumber = number;

        }
        #endregion

        #endregion

        #region Show Requests

        public void ShowRequests()
        {
            Request[] requests = Request();
            string line = "\nPedido  PT     Data       Horas  Estado   ";
            Console.WriteLine(line);
            Console.WriteLine(new string('_', line.Length));

            for (int i = 0; i < requests.Length; i++)
            {
                Console.WriteLine
                    (
                    $"{requests[i].RequestNumber.ToString("000")}\t{requests[i].PtCode}\t{requests[i].RequestDateHours.ToLongDateString()}\t{requests[i].RequestDateHours.ToShortTimeString()}\t{requests[i].RequestStatus}");               
            }
        }

        #endregion

        #endregion

    }
}
