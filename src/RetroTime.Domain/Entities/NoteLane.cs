// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : NoteLane.cs
//  Project         : RetroTime.Domain
// ******************************************************************************

namespace RetroTime.Domain.Entities;

/// <summary>
/// A lane represents a place where notes go. A lane is one of "start", "stop", "continue"
/// </summary>
public class NoteLane {
    public KnownNoteLane Id { get; set; }

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
}
