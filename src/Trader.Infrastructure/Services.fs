namespace Hse.Infrastructure.Services

open Hse.Application.Services
open Rebus.Bus
open System
open System.Threading.Tasks
//open FSharp.Control.Tasks
open Rebus.Handlers
open Hse.Application.Contracts

//type CommandBus(bus: IBus) =
//        interface ICommandBus with
//                member __.SendAsync command = task {try
//                                                        do! command |> bus.Send
//                                                        Ok ()
//                                                    with
//                                                        | :? Exception as ex -> Error ex.Message
//                                                }

type WarehouseCommandHandler() =
    interface IHandleMessages<WarehouseCommand> with
        member __.Handle (command: WarehouseCommand) = 
            match command with
            | Create (id, name) ->
                Task.CompletedTask
            | _ -> Task.CompletedTask