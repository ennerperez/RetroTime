// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : IVoteChangeSubscriber.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.VoteChanged;

using System.Threading.Tasks;

public interface IVoteChangeSubscriber : ISubscriber {
    Task OnVoteChange(VoteChange notification);
}
