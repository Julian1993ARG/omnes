import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EtiquetasRow {
    IdEtiqueta?: number;
    Descripcion?: string;
    Baja?: boolean;
    Observaciones?: string;
    IdTennant?: number;
    IdTennantDescripcion?: string;
}

export abstract class EtiquetasRow {
    static readonly idProperty = 'IdEtiqueta';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.Etiquetas';
    static readonly deletePermission = 'RRHH';
    static readonly insertPermission = 'RRHH';
    static readonly readPermission = 'RRHH';
    static readonly updatePermission = 'RRHH';

    static readonly Fields = fieldsProxy<EtiquetasRow>();
}