// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
// 
//  File:           : RetrospectiveVoteStatus.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Votes.Queries;

public sealed class GetVotesQueryResult {
    public RetrospectiveVoteStatus VoteStatus { get; }

    public GetVotesQueryResult(RetrospectiveVoteStatus voteStatus) {
        this.VoteStatus = voteStatus;
    }
}
