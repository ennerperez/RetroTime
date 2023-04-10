// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : IIdPrimaryKey.cs
//  Project         : RetroTime.Domain
// ******************************************************************************

namespace RetroTime.Domain.Abstractions;

public interface IIdPrimaryKey {
    int Id { get; }
}
