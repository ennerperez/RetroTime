﻿// ******************************************************************************
//  ©  Sebastiaan Dammann | damsteen.nl
//
//  File:           : SecurityValidatorExtensions.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Common.Security;

using System;
using System.Threading.Tasks;
using Domain.Entities;

public static class SecurityValidatorExtensions {
    public static ValueTask EnsureAddOrUpdate(this ISecurityValidator securityValidator, Retrospective retrospective, object entity) {
        if (securityValidator == null) throw new ArgumentNullException(nameof(securityValidator));
        return securityValidator.EnsureOperation(retrospective, SecurityOperation.AddOrUpdate, entity);
    }
    public static ValueTask EnsureDelete(this ISecurityValidator securityValidator, Retrospective retrospective, object entity) {
        if (securityValidator == null) throw new ArgumentNullException(nameof(securityValidator));
        return securityValidator.EnsureOperation(retrospective, SecurityOperation.Delete, entity);
    }

}
