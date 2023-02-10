using System;
using Utilities;

namespace RSGymPT.Interfaces
{
    internal interface IPersonalTrainer
    {
        #region Properties
        string PtCode { get; }
        string PtName { get; }
        #endregion

        #region Methods
        PersonalTrainer[] CreatePt();
        void ShowPt();
        #endregion
    }
}
