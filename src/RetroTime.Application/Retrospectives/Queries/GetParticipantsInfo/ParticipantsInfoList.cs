// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : ParticipantsInfoList.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Retrospectives.Queries.GetParticipantsInfo;

using System.Collections.Generic;

public class ParticipantsInfoList {
    public List<ParticipantInfo> Participants { get; } = new List<ParticipantInfo>();
}
