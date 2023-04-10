﻿// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : ISubscriber.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notifications;

using System;

/// <summary>
/// Base interface for notification receiving entities
/// </summary>
public interface ISubscriber {
    /// <summary>
    /// A per-instance unique ID used for tracking the subscriber
    /// </summary>
    Guid UniqueId { get; }
}
