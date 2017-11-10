namespace Hse.Application.Contracts

open System
open Hse.Domain

type CreateWarehouseModel = {Name: string}
type RenameWarehouseModel = {Id: Guid ; NewName: string}

type WarehouseCommand =
    | Create of Id: WarehouseId * Name: WarehouseName
    | Rename of Id: WarehouseId * NewName: WarehouseName
        with
            static member ToCreateCommand (model: CreateWarehouseModel) =
                ((Guid.NewGuid() |> WarehouseId.Create), (model.Name |> WarehouseName.Create)) |> Create


