namespace Hse.DependencyResolution

open Microsoft.Extensions.DependencyInjection
open Hse.Application.Services
open Hse.Infrastructure.Services

module CompositionRoot =
    let Compose (services: IServiceCollection) =
        services.AddScoped<IWarehouseService, WarehouseService>()

