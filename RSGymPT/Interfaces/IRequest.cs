using System;
using Utilities;

namespace RSGymPT.Interfaces
{
    internal interface IRequest
    {
        int RequestNumber { get; }
        string RequestStatus { get; }
        string RequestPt { get; }
        DateTime RequestDateHours { get; }
    }
}
