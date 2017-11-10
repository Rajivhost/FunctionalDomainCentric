namespace Hse.DependencyInjection

open Microsoft.Extensions.DependencyInjection
open Hse.Application.Services
open Hse.Infrastructure.Services
open Rebus.ServiceProvider

module CompositionRoot =
    let Compose (services: IServiceCollection) =
        services.AutoRegisterHandlersFromAssemblyOf<WarehouseCommandHandler>();

