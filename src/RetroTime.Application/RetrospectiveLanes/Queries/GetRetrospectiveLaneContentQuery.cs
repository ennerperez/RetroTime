// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : GetRetrospectiveLaneContent.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.RetrospectiveLanes.Queries;

using MediatR;

public sealed class GetRetrospectiveLaneContentQuery : IRequest<RetrospectiveLaneContent> {
    public string RetroId { get; }
    public int LaneId { get; }

    public GetRetrospectiveLaneContentQuery(string retroId, int laneId) {
        this.RetroId = retroId;
        this.LaneId = laneId;
    }
}
