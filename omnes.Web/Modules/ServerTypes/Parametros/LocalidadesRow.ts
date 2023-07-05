import { fieldsProxy } from "@serenity-is/corelib/q";

export interface LocalidadesRow {
    IdLocalidad?: number;
    NombreLocalidad?: string;
    Baja?: boolean;
    IdProvincia?: number;
    IdPais?: number;
    IdProvinciaNombreProvincia?: string;
    IdPaisNombrePais?: string;
}

export abstract class LocalidadesRow {
    static readonly idProperty = 'IdLocalidad';
    static readonly nameProperty = 'NombreLocalidad';
    static readonly localTextPrefix = 'Parametros.Localidades';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<LocalidadesRow>();
}