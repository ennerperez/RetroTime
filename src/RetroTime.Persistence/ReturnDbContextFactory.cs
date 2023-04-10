// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : ReturnDbContextFactory.cs
//  Project         : RetroTime.Persistence
// ******************************************************************************

namespace RetroTime.Persistence;

using Microsoft.EntityFrameworkCore;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1812:Avoid uninstantiated internal classes", Justification = "EF Core infra")]
internal class ReturnDbContextFactory : DesignTimeDbContextFactoryBase<ReturnDbContext> {
    protected override ReturnDbContext CreateNewInstance(DbContextOptions<ReturnDbContext> options) => new ReturnDbContext(options);
}
