import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CodigosPostalesRow {
    IdCodPostal?: number;
    CodPostal?: string;
    Baja?: boolean;
    IdLocalidad?: number;
    IdProvincia?: number;
    IdPais?: number;
    IdLocalidadNombreLocalidad?: string;
    IdProvinciaNombreProvincia?: string;
    IdPaisNombrePais?: string;
}

export abstract class CodigosPostalesRow {
    static readonly idProperty = 'IdCodPostal';
    static readonly nameProperty = 'CodPostal';
    static readonly localTextPrefix = 'Parametros.CodigosPostales';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<CodigosPostalesRow>();
}