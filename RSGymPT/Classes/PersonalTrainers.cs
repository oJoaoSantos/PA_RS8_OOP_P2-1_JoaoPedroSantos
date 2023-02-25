using RSGymPT.Interfaces;
using System;
using System.Collections.Generic;

namespace RSGymPT
{

    internal class PersonalTrainers : IPersonalTrainers
    {
        #region Class Variables
        List<PersonalTrainer> personalTrainers = new List<PersonalTrainer>();

        #endregion

        #region Constructors
        public PersonalTrainers()
        {
            personalTrainers.Add(new PersonalTrainer { PtCode = "JLS", PtName = "João Loureiro Santos", PtPhone = "912 345 678" });
            personalTrainers.Add(new PersonalTrainer { PtCode = "MSF", PtName = "Matilde Sousa Ferreira", PtPhone = "961 223 567" });
            personalTrainers.Add(new PersonalTrainer { PtCode = "EST", PtName = "Érica Santos Teixeira", PtPhone = "939 876 543" });
        }
        #endregion

        #region Methods

        public string AskPtCode()
        {
            PersonalTrainer founded;
            string ptCodeReaded;
            do
            {
                Console.Write("Código do PT > ");
                ptCodeReaded = Console.ReadLine();
                founded = personalTrainers.Find(element => element.PtCode.Equals(ptCodeReaded.ToUpper()));
            } while (founded == null);
            return ptCodeReaded.ToUpper();
        }

        #region Show PT
        public void ShowPt()
        {
            Utilities.Basics.Title01("Lista de Personal Trainers");

            foreach (PersonalTrainer pt in personalTrainers)
            {
                pt.PrintPts();
            }
        }
        #endregion

        #endregion

    }
}
