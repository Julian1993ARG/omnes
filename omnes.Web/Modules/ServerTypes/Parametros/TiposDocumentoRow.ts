import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TiposDocumentoRow {
    IdTipoDocumento?: number;
    NombreTipoDocumento?: string;
    Baja?: boolean;
    Sigla?: string;
}

export abstract class TiposDocumentoRow {
    static readonly idProperty = 'IdTipoDocumento';
    static readonly nameProperty = 'NombreTipoDocumento';
    static readonly localTextPrefix = 'Parametros.TiposDocumento';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<TiposDocumentoRow>();
}