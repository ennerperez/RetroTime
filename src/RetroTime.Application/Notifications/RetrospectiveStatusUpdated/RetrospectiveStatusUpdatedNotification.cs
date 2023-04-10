// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : RetrospectiveStatusUpdatedNotification.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.RetrospectiveStatusUpdated;

using MediatR;
using Retrospectives.Queries.GetRetrospectiveStatus;

public sealed class RetrospectiveStatusUpdatedNotification : INotification {
    public RetrospectiveStatus RetrospectiveStatus { get; }

    public RetrospectiveStatusUpdatedNotification(RetrospectiveStatus retrospectiveStatus) {
        this.RetrospectiveStatus = retrospectiveStatus;
    }
}
