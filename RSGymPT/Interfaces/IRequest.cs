using System;
using Utilities;

namespace RSGymPT.Interfaces
{
    internal interface IRequest
    {
        #region Properties
        int RequestNumber { get; }
        int ClientNumber { get; }
        string PtCode { get; }
        DateTime RequestDateHours { get; }
        string RequestStatus { get; }
        #endregion

        #region Methods

        #endregion

    }
}
