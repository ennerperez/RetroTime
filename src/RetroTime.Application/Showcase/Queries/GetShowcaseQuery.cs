// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
// 
//  File:           : GetShowcaseQuery.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Showcase.Queries;

using Common.Behaviours;
using MediatR;

public sealed class GetShowcaseQuery : IRequest<GetShowcaseQueryResult>, ILockFreeRequest {
    public string RetroId { get; }

    public GetShowcaseQuery(string retroId) {
        this.RetroId = retroId;
    }
}
