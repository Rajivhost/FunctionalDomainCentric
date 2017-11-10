namespace Hse.Domain
open System

type WarehouseId = private WarehouseId of Guid
                    with 
                        static member Create id = id |> WarehouseId
                        static member GetValue (WarehouseId id) = id
                        static member Empty = Guid.Empty |> WarehouseId

type WarehouseName = private WarehouseName of string
                      with
                        static member Create name = name |> WarehouseName
                        static member GetValue (WarehouseName name) = name
                        static member Empty = "" |> WarehouseName

type WarehouseData = {Id: WarehouseId; Name: WarehouseName}
                       with
                        static member Empty = {Id = WarehouseId.Empty; Name = WarehouseName.Empty}

type WarehouseState = 
    | Initial
    | Created of WarehouseData

type WarehouseEvent =
    | Created of Id: WarehouseId * Name: WarehouseName
    | Renamed of Id: WarehouseId * OldName: WarehouseName * NewName: WarehouseName

type WarehouseError =
    | CreateFailed of Id: WarehouseId * Message: string
    | RenameFailed of Id: WarehouseId * Message: string

