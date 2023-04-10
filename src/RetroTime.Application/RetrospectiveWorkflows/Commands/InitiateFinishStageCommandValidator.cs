// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
// 
//  File:           : InitiateFinishStageCommandValidator.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.RetrospectiveWorkflows.Commands;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "This is a validation rule set.")]
public sealed class InitiateFinishStageCommandValidator : AbstractStageCommandValidator<InitiateFinishStageCommand> { }
