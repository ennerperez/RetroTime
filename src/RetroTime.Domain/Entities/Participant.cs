﻿// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : Participant.cs
//  Project         : RetroTime.Domain
// ******************************************************************************

namespace RetroTime.Domain.Entities;

using Abstractions;
using ValueObjects;

#nullable disable
public class Participant : IIdPrimaryKey {
    public int Id { get; set; }

    public ParticipantColor Color { get; set; }

    public Retrospective Retrospective { get; set; }

    public string Name { get; set; }

    public bool IsFacilitator { get; set; }
}
