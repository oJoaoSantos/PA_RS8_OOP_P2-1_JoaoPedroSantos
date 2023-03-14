using RSGymPT.Interfaces;
using System;
using System.Collections.Generic;

namespace RSGymPT
{

    public class PersonalTrainer : IPersonalTrainer 
    {
        #region Class Variables
        static int autoPtId = 0;
        List<PersonalTrainer> personalTrainers = new List<PersonalTrainer>();
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

            PtId = autoPtId++;
            PtCode = ptCode;
            PtName = ptName;
            PtPhone = ptPhone;
        }
        #endregion

        #region Methods

        #region Data Creation
        public void CreatePersonalTrainers()
        {
            personalTrainers.Add(new PersonalTrainer { PtCode = "JLS", PtName = "João Loureiro Santos", PtPhone = "912 345 678" });
            personalTrainers.Add(new PersonalTrainer { PtCode = "MSF", PtName = "Matilde Sousa Ferreira", PtPhone = "961 223 567" });
            personalTrainers.Add(new PersonalTrainer { PtCode = "EST", PtName = "Érica Santos Teixeira", PtPhone = "939 876 543" });
        }
        #endregion

        #region Ask PT Code
        public string AskPtCode()
        {
            PersonalTrainer founded;
            string ptCodeReaded;
            do
            {
                Console.Write("\nCódigo do PT > ");
                ptCodeReaded = Console.ReadLine();
                founded = personalTrainers.Find(element => element.PtCode.Equals(ptCodeReaded.ToUpper()));
            } while (founded == null);
            return ptCodeReaded.ToUpper();
        }
        #endregion

        #region Show PT
        public void ShowPt()
        {
            Utilities.Basics.Title01("Lista de Personal Trainers");
            personalTrainers.Sort((x, y) => string.Compare(x.PtName, y.PtName));
            foreach (PersonalTrainer pt in personalTrainers)
            {
                Console.WriteLine($"\n\nID: {pt.PtId}\tCódigo: {pt.PtCode}\tNome: {pt.PtName}\tContacto: {pt.PtPhone}");
            }
        }
        #endregion

        #region Validate PT
        public PersonalTrainer ValidatePt(string ptCodeReaded)
        {
            string ptCode = ptCodeReaded;
            PersonalTrainer founded = personalTrainers.Find(element => element.PtCode == ptCodeReaded);
            return founded;
        }
        #endregion

        #endregion
    }
}
