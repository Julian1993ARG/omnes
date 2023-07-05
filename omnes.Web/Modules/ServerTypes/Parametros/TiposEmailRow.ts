import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TiposEmailRow {
    IdTipoEmail?: number;
    NombreTipoEmail?: string;
}

export abstract class TiposEmailRow {
    static readonly idProperty = 'IdTipoEmail';
    static readonly nameProperty = 'NombreTipoEmail';
    static readonly localTextPrefix = 'Parametros.TiposEmail';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<TiposEmailRow>();
}