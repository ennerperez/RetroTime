// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : ServiceCollectionExtensions.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Domain;

using Services;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddDomain(this IServiceCollection services) {
        services.AddTransient<IPassphraseService, PassphraseService>();
        services.AddScoped<ITextAnonymizingService, TextAnonymizingService>();

        return services;
    }
}
