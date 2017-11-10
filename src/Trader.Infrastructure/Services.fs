namespace Hse.Infrastructure.Services

open Hse.Application.Services

type WarehouseService() =
        interface IWarehouseService with
                member __.Create model = Ok ()
