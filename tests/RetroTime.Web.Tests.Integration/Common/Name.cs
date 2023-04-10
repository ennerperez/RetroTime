// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : Name.cs
//  Project         : RetroTime.Web.Tests.Integration
// ******************************************************************************

namespace RetroTime.Web.Tests.Integration.Common;

using System;
using RetroTime.Common;

public static class Name {
    public static string Create() => Guid.NewGuid().ToString("N", Culture.Invariant);
}
