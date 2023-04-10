// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : GetRetrospectiveStatusQuery.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Retrospectives.Queries.GetRetrospectiveStatus;

using MediatR;

public sealed class GetRetrospectiveStatusQuery : IRequest<RetrospectiveStatus> {
    public string RetroId { get; }

    public GetRetrospectiveStatusQuery(string retroId) {
        this.RetroId = retroId;
    }
}
