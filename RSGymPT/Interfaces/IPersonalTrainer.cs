

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

        #region Data Creation
        void CreatePersonalTrainers();
        #endregion

        #region Ask PT Code
        string AskPtCode();
        #endregion

        #region Show PT
        void ShowPt();
        #endregion

        #region Validate PT
        PersonalTrainer ValidatePt(string ptCodeReaded);
        #endregion

        #endregion
    }
}
