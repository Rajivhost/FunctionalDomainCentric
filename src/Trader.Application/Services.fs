namespace Hse.Application.Services

open Hse.Application.Contracts

type IWarehouseService =
        abstract Create: model: CreateWarehouseModel -> Result<unit, string>;

