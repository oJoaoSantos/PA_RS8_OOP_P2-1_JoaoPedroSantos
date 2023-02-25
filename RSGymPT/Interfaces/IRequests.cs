using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSGymPT.Interfaces
{
    internal interface IRequests
    {
        #region Methods
        PersonalTrainer ValidatePt(string ptCodeReaded);
        void NewRequest(int clientNumber, string ptCode, DateTime date, DateTime hours);
        int AskRequestNumber();
        void AlterRequest(int requestNumber, int clientNumber, string ptCode, DateTime requestHours, DateTime requestDate);
        void DropRequest(int requestNumber);
        void TerminateRequest(int requestNumber);
        void ShowRequests();
        #endregion
    }
}
