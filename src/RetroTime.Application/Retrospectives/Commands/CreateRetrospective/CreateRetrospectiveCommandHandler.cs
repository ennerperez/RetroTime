﻿// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : CreateRetrospectiveCommandHandler.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Retrospectives.Commands.CreateRetrospective;

using System;
using System.Threading;
using System.Threading.Tasks;
using Common.Abstractions;
using Domain.Entities;
using Domain.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using Net.Codecrete.QrCodeGenerator;
using RetroTime.Common;
using Services;

public sealed class CreateRetrospectiveCommandHandler : IRequestHandler<CreateRetrospectiveCommand, CreateRetrospectiveCommandResponse> {
    private readonly IReturnDbContext _returnDbContext;
    private readonly ISystemClock _systemClock;
    private readonly IUrlGenerator _urlGenerator;
    private readonly IPassphraseService _passphraseService;
    private readonly ILogger<CreateRetrospectiveCommandHandler> _logger;

    public CreateRetrospectiveCommandHandler(IReturnDbContext returnDbContext, IPassphraseService passphraseService, ISystemClock systemClock, IUrlGenerator urlGenerator, ILogger<CreateRetrospectiveCommandHandler> logger) {
        this._returnDbContext = returnDbContext;
        this._passphraseService = passphraseService;
        this._systemClock = systemClock;
        this._urlGenerator = urlGenerator;
        this._logger = logger;
    }

    public async Task<CreateRetrospectiveCommandResponse> Handle(CreateRetrospectiveCommand request, CancellationToken cancellationToken) {
        if (request == null) throw new ArgumentNullException(nameof(request));

        string? HashOptionalPassphrase(string? plainText) {
            return !String.IsNullOrEmpty(plainText) ? this._passphraseService.CreateHashedPassphrase(plainText) : null;
        }

        var retrospective = new Retrospective {
            CreationTimestamp = this._systemClock.CurrentTimeOffset,
            Title = request.Title,
            HashedPassphrase = HashOptionalPassphrase(request.Passphrase),
            FacilitatorHashedPassphrase = HashOptionalPassphrase(request.FacilitatorPassphrase) ?? throw new InvalidOperationException("No facilitator passphrase given"),
        };

        this._logger.LogInformation($"Creating new retrospective with id {retrospective.UrlId}");

        string retroLocation = this._urlGenerator.GenerateUrlToRetrospectiveLobby(retrospective.UrlId).ToString();

        var qrCode =  QrCode.EncodeText(retroLocation, QrCode.Ecc.Low);

        var result = new CreateRetrospectiveCommandResponse(
            retrospective.UrlId,
            qrCode,
            retroLocation);

        this._returnDbContext.Retrospectives.Add(retrospective);

        await this._returnDbContext.SaveChangesAsync(cancellationToken);

        return result;
    }
}
