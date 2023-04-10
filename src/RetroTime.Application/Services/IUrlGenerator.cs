// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : IUrlGenerator.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Services;

using System;
using Domain.ValueObjects;

public interface IUrlGenerator {
    Uri GenerateUrlToRetrospectiveLobby(RetroIdentifier urlId);
}
