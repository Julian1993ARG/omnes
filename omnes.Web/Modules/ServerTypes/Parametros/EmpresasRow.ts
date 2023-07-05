import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EmpresasRow {
    IdEmpresa?: number;
    IdTennant?: number;
    RazonSocial?: string;
    Cuit?: string;
    InicioActividades?: string;
    DireccionUrl?: string;
    NombreFantasia?: string;
    Mail?: string;
    NombreContacto?: string;
    Telefono?: string;
    Calle?: string;
    Altura?: string;
    Piso?: string;
    Dpto?: string;
    Latitud?: string;
    Longitud?: string;
    OtraReferencia?: string;
    IdLocalidad?: number;
    IdCodPost?: number;
    IdProvincia?: number;
    IdPais?: number;
    Logo?: string;
    DocumentosRelacionados?: string;
    Baja?: boolean;
    Observaciones?: string;
    IdTennantDescripcion?: string;
    IdCodPostCodPostal?: string;
    IdProvinciaNombreProvincia?: string;
    IdPaisNombrePais?: string;
}

export abstract class EmpresasRow {
    static readonly idProperty = 'IdEmpresa';
    static readonly nameProperty = 'RazonSocial';
    static readonly localTextPrefix = 'Parametros.Empresas';
    static readonly deletePermission = 'RRHH';
    static readonly insertPermission = 'RRHH';
    static readonly readPermission = 'RRHH';
    static readonly updatePermission = 'RRHH';

    static readonly Fields = fieldsProxy<EmpresasRow>();
}