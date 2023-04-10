﻿// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : CreateRetrospectiveCommandHandlerTests.cs
//  Project         : RetroTime.Application.Tests.Unit
// ******************************************************************************

namespace RetroTime.Application.Tests.Unit.Retrospectives.Commands;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RetroTime.Application.Retrospectives.Commands.CreateRetrospective;
using Domain.Services;
using Domain.ValueObjects;
using Microsoft.Extensions.Logging.Abstractions;
using NSubstitute;
using NUnit.Framework;
using RetroTime.Common;
using Services;
using Support;

[TestFixture]
public sealed class CreateRetrospectiveCommandHandlerTests : CommandTestBase {
    [Test]
    public async Task Handle_GivenValidRequest_ShouldSaveRetrospectiveWithHash() {
        // Given
        var passphraseService = Substitute.For<IPassphraseService>();
        var systemClock = Substitute.For<ISystemClock>();
        var urlGenerator = Substitute.For<IUrlGenerator>();
        var handler = new CreateRetrospectiveCommandHandler(this.Context, passphraseService, systemClock, urlGenerator, new NullLogger<CreateRetrospectiveCommandHandler>());

        passphraseService.CreateHashedPassphrase("anything").Returns("myhash");
        passphraseService.CreateHashedPassphrase("facilitator password").Returns("facilitatorhash");

        urlGenerator.GenerateUrlToRetrospectiveLobby(Arg.Any<RetroIdentifier>()).Returns(new Uri("https://example.com/retro/1"));

        systemClock.CurrentTimeOffset.Returns(DateTimeOffset.UnixEpoch);

        var request = new CreateRetrospectiveCommand {
            Passphrase = "anything",
            FacilitatorPassphrase = "facilitator password",
            Title = "Hello"
        };

        // When
        CreateRetrospectiveCommandResponse result = await handler.Handle(request, CancellationToken.None);

        // Then
        Assert.That(result.Identifier.StringId, Is.Not.Null);
        Assert.That(this.Context.Retrospectives.Any(), Is.True);
        Assert.That(this.Context.Retrospectives.First().FacilitatorHashedPassphrase, Is.EqualTo("facilitatorhash"));
        Assert.That(this.Context.Retrospectives.First().CreationTimestamp, Is.EqualTo(DateTimeOffset.UnixEpoch));
    }
}
