// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : VoteChangeNotification.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.VoteChanged;

using MediatR;

public sealed class VoteChangeNotification : INotification {
    public VoteChange VoteChange { get; }

    public VoteChangeNotification(VoteChange voteChange) {
        this.VoteChange = voteChange;
    }
}
