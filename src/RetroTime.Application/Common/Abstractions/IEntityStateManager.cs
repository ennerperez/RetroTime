// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : IEntityStateFacilitator.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Common.Abstractions;

using System.Threading;
using System.Threading.Tasks;

public interface IEntityStateFacilitator {
    Task Reload(object entity, CancellationToken cancellationToken);
}
