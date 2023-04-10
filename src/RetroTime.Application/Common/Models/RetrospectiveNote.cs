﻿// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : RetrospectiveNote.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Common.Models;

using System;
using AutoMapper;
using Domain.Entities;
using Mapping;

#nullable disable

public sealed class RetrospectiveNote : IMapFrom<Note> {
    public int Id { get; set; }

    public int ParticipantId { get; set; }
    public string ParticipantName { get; set; }

    public ColorModel ParticipantColor { get; set; }

    public string Text { get; set; }
    public bool IsOwnedByCurrentUser { get; set; }
    public int? GroupId { get; set; }

    public void Mapping(Profile profile) {
        if (profile == null) throw new ArgumentNullException(nameof(profile));
        profile.CreateMap<Note, RetrospectiveNote>()
            .ForMember(x => x.IsOwnedByCurrentUser, m => m.Ignore());
    }
}
