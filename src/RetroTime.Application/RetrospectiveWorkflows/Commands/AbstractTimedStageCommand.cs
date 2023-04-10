// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : AbstractTimedStageCommand.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.RetrospectiveWorkflows.Commands;
#nullable disable

public abstract class AbstractStageCommand {
    public string RetroId { get; set; }

}

public abstract class AbstractTimedStageCommand : AbstractStageCommand {
    public int TimeInMinutes { get; set; }
}
