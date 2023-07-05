import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EstadosCivilesRow {
    IdEstadoCivil?: number;
    DescripcionEstadoCivil?: string;
    Baja?: boolean;
}

export abstract class EstadosCivilesRow {
    static readonly idProperty = 'IdEstadoCivil';
    static readonly nameProperty = 'DescripcionEstadoCivil';
    static readonly localTextPrefix = 'Parametros.EstadosCiviles';
    static readonly deletePermission = 'SuperAdmin';
    static readonly insertPermission = 'SuperAdmin';
    static readonly readPermission = 'SuperAdmin';
    static readonly updatePermission = 'SuperAdmin';

    static readonly Fields = fieldsProxy<EstadosCivilesRow>();
}