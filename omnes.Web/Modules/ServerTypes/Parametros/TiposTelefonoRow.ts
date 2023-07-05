import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TiposTelefonoRow {
    IdTipoTelefono?: number;
    NombreTipoTelefono?: string;
}

export abstract class TiposTelefonoRow {
    static readonly idProperty = 'IdTipoTelefono';
    static readonly nameProperty = 'NombreTipoTelefono';
    static readonly localTextPrefix = 'Parametros.TiposTelefono';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<TiposTelefonoRow>();
}