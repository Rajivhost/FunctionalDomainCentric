namespace Hse.Infrastructure.Services

open Hse.Application.Services
open Rebus.Bus
open System
open System.Threading.Tasks
open Rebus.Handlers
open Hse.Application.Contracts

type WarehouseCommandHandler() =
    interface IHandleMessages<WarehouseCommand> with
        member __.Handle (command: WarehouseCommand) =
            match command with
            | Create (id, name) ->
                Task.CompletedTask
            | _ -> Task.CompletedTask