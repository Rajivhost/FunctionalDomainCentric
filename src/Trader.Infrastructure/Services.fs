namespace Hse.Infrastructure.Services

open Hse.Application.Services
open Rebus.Bus
open System
open System.Threading.Tasks
open FSharp.Control.Tasks

//type CommandBus(bus: IBus) =
//        interface ICommandBus with
//                member __.SendAsync command = task {try
//                                                        do! command |> bus.Send
//                                                        Ok ()
//                                                    with
//                                                        | :? Exception as ex -> Error ex.Message
//                                                }
