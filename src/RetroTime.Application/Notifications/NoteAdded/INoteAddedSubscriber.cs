// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : INoteAddedSubscriber.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.NoteAdded;

using System.Threading.Tasks;

public interface INoteAddedSubscriber : ISubscriber {
    Task OnNoteAdded(NoteAddedNotification notification);
}
