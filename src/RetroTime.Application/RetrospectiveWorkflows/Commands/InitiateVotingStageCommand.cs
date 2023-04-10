// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
// 
//  File:           : InitiateVotingStageCommand.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.RetrospectiveWorkflows.Commands;

using MediatR;

public sealed class InitiateVotingStageCommand : AbstractTimedStageCommand, IRequest {
    public int VotesPerGroup { get; set; }
}
