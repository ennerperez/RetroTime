// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : RetrospectiveStatusUpdatedNotificationDispatcher.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.RetrospectiveStatusUpdated;

using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public sealed class RetrospectiveStatusUpdatedNotificationDispatcher : NotificationDispatcher<
    RetrospectiveStatusUpdatedNotification, IRetrospectiveStatusUpdatedSubscriber> {
    public RetrospectiveStatusUpdatedNotificationDispatcher(ILogger<NotificationDispatcher<RetrospectiveStatusUpdatedNotification, IRetrospectiveStatusUpdatedSubscriber>> logger) : base(logger)
    {
    }

    protected override Task DispatchCore(
        IRetrospectiveStatusUpdatedSubscriber subscriber,
        RetrospectiveStatusUpdatedNotification notification
    ) => subscriber.OnRetrospectiveStatusUpdated(notification.RetrospectiveStatus);
}
