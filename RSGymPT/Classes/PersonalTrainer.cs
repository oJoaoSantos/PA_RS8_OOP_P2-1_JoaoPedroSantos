using System;
using Utilities;

namespace RSGymPT
{
    internal class PersonalTrainer
    {
        #region Properties
        public string PtCode { get; set; }
        public string PtName { get; set;}
        #endregion

        #region Constructors
        public PersonalTrainer()
        {
            PtCode= string.Empty;
            PtName= string.Empty;
        }

        public PersonalTrainer(string ptCode, string ptName)
        {
            PtCode = ptCode;
            PtName = ptName;
        }

        #endregion

        #region Methods

        #region Data Creation
        public PersonalTrainer[] CreatePt()
        {
            PersonalTrainer[] personalTrainers = new PersonalTrainer[]
               {
                new PersonalTrainer { PtCode = "JPS", PtName = "João Pedro Loureiro Santos" },
                new PersonalTrainer { PtCode = "MLS", PtName = "Matilde Sousa Ferreira" },
                new PersonalTrainer { PtCode = "EST", PtName = "Érica Santos Teixeira" }
               };
            return personalTrainers;
        }
        #endregion

        #region Show PT

        public void ShowPt()
        {
            PersonalTrainer[] personalTrainers = CreatePt();
            string line = $"\n{personalTrainers[0].PtCode}   \t| {personalTrainers[0].PtName}";


            Console.WriteLine("\nCódigo\t| Nome");
            Console.WriteLine(new string('_', line.Length));

            for (int i = 0; i < personalTrainers.Length; i++)
            {
                Console.WriteLine($"\n{personalTrainers[i].PtCode}   \t| {personalTrainers[i].PtName}");
                Console.WriteLine(new string('_', line.Length));
            }
        }

        #endregion

        #endregion

    }
}
