// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : NoteUpdatedNotificationDispatcher.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.NoteUpdated;

using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public sealed class NoteUpdatedNotificationDispatcher : NotificationDispatcher<NoteUpdatedNotification, INoteUpdatedSubscriber> {
    public NoteUpdatedNotificationDispatcher(ILogger<NotificationDispatcher<NoteUpdatedNotification, INoteUpdatedSubscriber>> logger) : base(logger)
    {
    }

    protected override Task DispatchCore(
        INoteUpdatedSubscriber subscriber,
        NoteUpdatedNotification notification
    ) => subscriber.OnNoteUpdated(notification.Note);
}
