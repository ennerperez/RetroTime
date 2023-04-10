// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : RetrospectiveEvent.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications;

public sealed class RetrospectiveEvent<T> {
    public string RetroId { get; }

    public T Argument { get; }

    public RetrospectiveEvent(string retroId, T argument) {
        this.RetroId = retroId;
        this.Argument = argument;
    }
}
