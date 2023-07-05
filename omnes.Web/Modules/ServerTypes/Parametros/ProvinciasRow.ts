import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProvinciasRow {
    IdProvincia?: number;
    NombreProvincia?: string;
    Baja?: boolean;
    IdPais?: number;
    IdPaisNombrePais?: string;
}

export abstract class ProvinciasRow {
    static readonly idProperty = 'IdProvincia';
    static readonly nameProperty = 'NombreProvincia';
    static readonly localTextPrefix = 'Parametros.Provincias';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<ProvinciasRow>();
}