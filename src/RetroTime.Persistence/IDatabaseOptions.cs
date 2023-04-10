// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : IDatabaseOptions.cs
//  Project         : RetroTime.Persistence
// ******************************************************************************

namespace RetroTime.Persistence;

public interface IDatabaseOptions {
    string CreateConnectionString();
    DatabaseProvider DatabaseProvider { get; }
}


public enum DatabaseProvider {
    SqlServer,
    Sqlite
}
