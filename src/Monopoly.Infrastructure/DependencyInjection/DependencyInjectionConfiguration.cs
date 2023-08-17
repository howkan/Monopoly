namespace Monopoly.Infrastructure.DependencyInjection;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IPalletFactory, PalletRandomFactory>();

        services.AddTransient<IBoxFactory, BoxRandomFactory>();

        services.AddTransient<IPalletRepository, PalletRandomRepository>();

        services.AddTransient<IPalletService, PalletService>();

        return services;
    }
}