// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : MachineDateTime.cs
//  Project         : RetroTime.Infrastructure
// ******************************************************************************

namespace RetroTime.Infrastructure;

using System;
using RetroTime.Common;

public sealed class MachineSystemClock : ISystemClock {
    public DateTime Now => DateTime.Now;
    public DateTimeOffset CurrentTimeOffset => DateTimeOffset.Now;
}
