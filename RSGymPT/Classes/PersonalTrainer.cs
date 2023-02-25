using RSGymPT.Interfaces;
using System;
using Utilities;

namespace RSGymPT
{

    internal class PersonalTrainer : IPersonalTrainer
    {
        #region Class Variables
        static int autoPtId = 1;
        #endregion

        #region Properties
        public int PtId { get; set; }
        public string PtCode { get; set; }
        public string PtName { get; set; }
        public string PtPhone { get; set; }
        #endregion

        #region Constructors
        public PersonalTrainer()
        {
            PtId = autoPtId++;
            PtCode = string.Empty;
            PtName = string.Empty;
            PtPhone = string.Empty;
        }
        public PersonalTrainer(string ptCode, string ptName, string ptPhone)
        {

            PtId = autoPtId;
            PtCode = ptCode;
            PtName = ptName;
            PtPhone = ptPhone;
        }
        #endregion

        #region Methods

        #region Data Creation
        public PersonalTrainer[] CreatePt()
        {
            PersonalTrainer[] personalTrainers = new PersonalTrainer[]
               {
                new PersonalTrainer { PtCode = "JLS", PtName = "João Loureiro Santos", PtPhone = "912 345 678" },
                new PersonalTrainer { PtCode = "MSF", PtName = "Matilde Sousa Ferreira", PtPhone = "961 223 567" },
                new PersonalTrainer { PtCode = "EST", PtName = "Érica Santos Teixeira", PtPhone = "939 876 543" }
               };
            return personalTrainers;
        }
        #endregion


        public void PrintPts()
        {
            Console.WriteLine($"\n\nID: {PtId}\tCódigo: {PtCode}\tNome: {PtName}\tContacto: {PtPhone}");
        }
        #endregion
    }
}
