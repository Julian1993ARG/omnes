import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TiposCuentasBancariaRow {
    IdTipoCuentaBancaria?: number;
    Descripcion?: string;
    Baja?: boolean;
    Observaciones?: string;
}

export abstract class TiposCuentasBancariaRow {
    static readonly idProperty = 'IdTipoCuentaBancaria';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.TiposCuentasBancaria';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<TiposCuentasBancariaRow>();
}