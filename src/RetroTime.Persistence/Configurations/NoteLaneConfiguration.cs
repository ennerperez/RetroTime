// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : NoteLaneConfiguration.cs
//  Project         : RetroTime.Persistence
// ******************************************************************************

namespace RetroTime.Persistence.Configurations;

using System;
using RetroTime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class NoteLaneConfiguration : IEntityTypeConfiguration<NoteLane> {
    public void Configure(EntityTypeBuilder<NoteLane> builder) {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name).HasMaxLength(256).IsRequired(true);
    }
}
