// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : Class1.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.NoteMoved;

using System.Threading.Tasks;

public interface INoteMovedSubscriber : ISubscriber {
    Task OnNoteMoved(NoteMovedNotification notification);
}
