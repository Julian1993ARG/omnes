import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TiposDomicilioRow {
    IdTipoDomicilio?: number;
    NombreTipoDomicilio?: string;
}

export abstract class TiposDomicilioRow {
    static readonly idProperty = 'IdTipoDomicilio';
    static readonly nameProperty = 'NombreTipoDomicilio';
    static readonly localTextPrefix = 'Parametros.TiposDomicilio';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<TiposDomicilioRow>();
}