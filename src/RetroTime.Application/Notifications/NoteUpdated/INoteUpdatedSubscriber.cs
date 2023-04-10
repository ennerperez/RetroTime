// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : INoteUpdatedSubscriber.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.NoteUpdated;

using System.Threading.Tasks;

public interface INoteUpdatedSubscriber : ISubscriber {
    Task OnNoteUpdated(NoteUpdate note);
}
