import { fieldsProxy } from "@serenity-is/corelib/q";

export interface PaisesRow {
    IdPais?: number;
    NombrePais?: string;
    Baja?: boolean;
}

export abstract class PaisesRow {
    static readonly idProperty = 'IdPais';
    static readonly nameProperty = 'NombrePais';
    static readonly localTextPrefix = 'Parametros.Paises';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<PaisesRow>();
}