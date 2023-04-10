// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : GetVotesQuery.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Votes.Queries;

using MediatR;

public sealed class GetVotesQuery : IRequest<GetVotesQueryResult> {
    public string RetroId { get; }

    public GetVotesQuery(string retroId) {
        this.RetroId = retroId;
    }
}
