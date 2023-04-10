﻿// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : UpdateNoteCommand.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Notes.Commands.UpdateNote;

using MediatR;

#nullable disable

public sealed class UpdateNoteCommand : IRequest {
    public int Id { get; set; }
    public string Text { get; set; }

    public override string ToString() => $"[{nameof(UpdateNoteCommand)}] Id: {this.Id} - Text: {this.Text}";
}
