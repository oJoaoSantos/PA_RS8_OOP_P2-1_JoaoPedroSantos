using System;
using Utilities;

namespace RSGymPT.Interfaces
{
    internal interface IPersonalTrainer
    {
        #region Properties
        int PtId { get; }
        string PtCode { get; }
        string PtName { get; }
        string PtPhone { get; }
        #endregion

        #region Methods
        PersonalTrainer[] CreatePt();
        void ShowPt();
        #endregion
    }
}
