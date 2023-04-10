// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : GetJoinRetrospectiveInfoQuery.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Retrospectives.Queries.GetJoinRetrospectiveInfo;

using MediatR;

public sealed class GetJoinRetrospectiveInfoQuery : IRequest<JoinRetrospectiveInfo?> {
#nullable disable
    public string RetroId { get; set; }
}
