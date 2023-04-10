// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : IOwnedByParticipant.cs
//  Project         : RetroTime.Domain
// ******************************************************************************

namespace RetroTime.Domain.Abstractions;

public interface IOwnedByParticipant {
    int ParticipantId { get; }
}
