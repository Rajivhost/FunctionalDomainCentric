namespace Hse.Application.Services

open System.Threading.Tasks
open Hse.Domain
open System

type ICommandBus =
        abstract SendAsync: command: obj -> Task<Result<unit, string>>

type IWarehouseRepository =
        abstract SaveAsync: event: WarehouseEvent -> Task<Result<unit, string>>;
        abstract GetByIdAsync: id: WarehouseId -> Task<Result<WarehouseState, string>>;
        inherit IDisposable

