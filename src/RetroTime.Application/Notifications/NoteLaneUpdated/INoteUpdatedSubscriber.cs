// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : INoteUpdatedSubscriber.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.NoteLaneUpdated;

using System.Threading.Tasks;

public interface INoteLaneUpdatedSubscriber : ISubscriber {
    Task OnNoteLaneUpdated(NoteLaneUpdatedNotification note);
}
