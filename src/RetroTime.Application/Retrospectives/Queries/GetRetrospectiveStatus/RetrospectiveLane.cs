﻿// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : RetrospectiveLane.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Retrospectives.Queries.GetRetrospectiveStatus;

using System;
using AutoMapper;
using Common.Mapping;
using Domain.Entities;

#nullable disable

public sealed class RetrospectiveLane : IMapFrom<NoteLane> {
    public int Id { get; set; }

    public string Name { get; set; }

    public int Color { get; set; }

    public void Mapping(Profile profile) {
        if (profile == null) throw new ArgumentNullException(nameof(profile));

        profile.CreateMap<NoteLane, RetrospectiveLane>()
            .ForMember(x => x.Id, m => m.MapFrom(e => (int)e.Id));
    }
}
