// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : VoteChange.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications.VoteChanged;

using Common.Models;

public sealed class VoteChange {
    public VoteModel Vote { get; }

    public string RetroId { get; }

    public VoteMutationType Mutation { get; }

    public VoteChange(string retroId, VoteModel vote, VoteMutationType mutation) {
        this.RetroId = retroId;
        this.Vote = vote;
        this.Mutation = mutation;
    }
}
