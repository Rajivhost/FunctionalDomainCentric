namespace Hse.Domain

module Warehouse =
    let Create id name = function
        | Initial -> (id, name) |> Created |> Ok
        | _ -> (id, "Invalid state to create a warehouse") |> CreateFailed |> Error
