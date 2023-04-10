// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : ISystemClock.cs
//  Project         : RetroTime.Common
// ******************************************************************************

namespace RetroTime.Common
{

    using System;

    public interface ISystemClock
    {
        DateTime Now { get; }

        DateTimeOffset CurrentTimeOffset { get; }
    }

}
