using RSGymPT.Interfaces;
using System;
using Utilities;

namespace RSGymPT
{
    internal class PersonalTrainer : IPersonalTrainer
    {
        #region Class Variables
        int autoPtId = 1;
        #endregion

        #region Properties
        public int PtId { get; set; }
        public string PtCode { get; set; }
        public string PtName { get; set;}
        public string PtPhone { get; set; }
        #endregion

        #region Constructors
        public PersonalTrainer()
        {
            PtId= autoPtId;
            PtCode= string.Empty;
            PtName= string.Empty;
            PtPhone= string.Empty;
        }
        public PersonalTrainer(int ptId, string ptCode, string ptName, string ptPhone)
        {
            PtId = ptId;
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
                new PersonalTrainer { PtId = autoPtId++, PtCode = "JLS", PtName = "João Loureiro Santos", PtPhone = "912 345 678" },
                new PersonalTrainer { PtId = autoPtId++, PtCode = "MSF", PtName = "Matilde Sousa Ferreira", PtPhone = "961 223 567" },
                new PersonalTrainer { PtId = autoPtId++, PtCode = "EST", PtName = "Érica Santos Teixeira", PtPhone = "939 876 543" }
               };
            return personalTrainers;
        }
        #endregion

        #region Show PT
        public void ShowPt()
        {
            PersonalTrainer[] personalTrainers = CreatePt();

            Utilities.Basics.Title01("Lista de Personal Trainers");

            for (int i = 0; i < personalTrainers.Length; i++)
            {
                Console.WriteLine($"\n\nID: {personalTrainers[i].PtId}\tCódigo: {personalTrainers[i].PtCode}\tNome: {personalTrainers[i].PtName}\tContacto: {personalTrainers[i].PtPhone}");
            }
        }
        #endregion

        #endregion

    }
}
