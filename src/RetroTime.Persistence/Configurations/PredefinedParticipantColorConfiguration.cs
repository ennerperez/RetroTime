// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : PredefinedParticipantColorConfiguration.cs
//  Project         : RetroTime.Persistence
// ******************************************************************************


namespace RetroTime.Persistence.Configurations;

using System;
using RetroTime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class PredefinedParticipantColorConfiguration : IEntityTypeConfiguration<PredefinedParticipantColor> {
    public void Configure(EntityTypeBuilder<PredefinedParticipantColor> builder) {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        builder.OwnsOne(e => e.Color);

        builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
    }
}
