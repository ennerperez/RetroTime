// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : ITypeSecurityHandler.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Common.Security.TypeHandling;

using Domain.Entities;
using Models;

internal interface ITypeSecurityHandler {
    void HandleOperation(SecurityOperation operation, Retrospective retrospective, object entity, in CurrentParticipantModel currentParticipant);
}
