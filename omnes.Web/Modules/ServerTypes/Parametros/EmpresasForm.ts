import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EmpresasForm {
    IdTennant: IntegerEditor;
    RazonSocial: StringEditor;
    Cuit: StringEditor;
    InicioActividades: DateEditor;
    DireccionUrl: StringEditor;
    NombreFantasia: StringEditor;
    Mail: StringEditor;
    NombreContacto: StringEditor;
    Telefono: StringEditor;
    Calle: StringEditor;
    Altura: StringEditor;
    Piso: StringEditor;
    Dpto: StringEditor;
    Latitud: StringEditor;
    Longitud: StringEditor;
    OtraReferencia: StringEditor;
    IdLocalidad: IntegerEditor;
    IdCodPost: IntegerEditor;
    IdProvincia: IntegerEditor;
    IdPais: IntegerEditor;
    Logo: StringEditor;
    DocumentosRelacionados: StringEditor;
    Baja: BooleanEditor;
    Observaciones: StringEditor;
}

export class EmpresasForm extends PrefixedContext {
    static formKey = 'Parametros.Empresas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EmpresasForm.init)  {
            EmpresasForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(EmpresasForm, [
                'IdTennant', w0,
                'RazonSocial', w1,
                'Cuit', w1,
                'InicioActividades', w2,
                'DireccionUrl', w1,
                'NombreFantasia', w1,
                'Mail', w1,
                'NombreContacto', w1,
                'Telefono', w1,
                'Calle', w1,
                'Altura', w1,
                'Piso', w1,
                'Dpto', w1,
                'Latitud', w1,
                'Longitud', w1,
                'OtraReferencia', w1,
                'IdLocalidad', w0,
                'IdCodPost', w0,
                'IdProvincia', w0,
                'IdPais', w0,
                'Logo', w1,
                'DocumentosRelacionados', w1,
                'Baja', w3,
                'Observaciones', w1
            ]);
        }
    }
}