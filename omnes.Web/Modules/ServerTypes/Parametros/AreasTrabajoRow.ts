import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AreasTrabajoRow {
    IdAreaTrabajo?: number;
    IdTennant?: number;
    IdEmpresa?: number;
    Descripcion?: string;
    Baja?: boolean;
    IdTennantDescripcion?: string;
    IdEmpresaRazonSocial?: string;
}

export abstract class AreasTrabajoRow {
    static readonly idProperty = 'IdAreaTrabajo';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Parametros.AreasTrabajo';
    static readonly deletePermission = 'RRHH';
    static readonly insertPermission = 'RRHH';
    static readonly readPermission = 'RRHH';
    static readonly updatePermission = 'RRHH';

    static readonly Fields = fieldsProxy<AreasTrabajoRow>();
}