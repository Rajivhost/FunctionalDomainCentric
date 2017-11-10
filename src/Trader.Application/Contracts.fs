namespace Hse.Application.Contracts

open System

type CreateWarehouseModel = {Name: string}
type RenameWarehouseModel = {Id: Guid ; NewName: string}


