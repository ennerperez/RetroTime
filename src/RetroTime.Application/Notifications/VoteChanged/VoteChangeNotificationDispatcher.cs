// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : VoteChangeNotificationDispatcher.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.VoteChanged;

using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public sealed class VoteChangeNotificationDispatcher : NotificationDispatcher<VoteChangeNotification, IVoteChangeSubscriber> {
    public VoteChangeNotificationDispatcher(ILogger<NotificationDispatcher<VoteChangeNotification, IVoteChangeSubscriber>> logger) : base(logger) {
    }

    protected override Task DispatchCore(
        IVoteChangeSubscriber subscriber,
        VoteChangeNotification notification
    ) => subscriber.OnVoteChange(notification.VoteChange);
}
