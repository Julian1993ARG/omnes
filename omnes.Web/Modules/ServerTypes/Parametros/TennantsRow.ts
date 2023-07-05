import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TennantsRow {
    IdTennant?: number;
    Descripcion?: string;
    Baja?: boolean;
    Observaciones?: string;
}

export abstract class TennantsRow {
    static readonly idProperty = 'IdTennant';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.Tennants';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<TennantsRow>();
}