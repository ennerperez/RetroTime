// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : ServerOptions.cs
//  Project         : RetroTime.Web
// ******************************************************************************

namespace RetroTime.Web.Configuration;

public class ServerOptions {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1056:Uri properties should not be strings", Justification = "User configurable")]
    public string? BaseUrl { get; set; }
}
