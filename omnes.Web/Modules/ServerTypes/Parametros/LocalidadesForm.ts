import { StringEditor, BooleanEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface LocalidadesForm {
    NombreLocalidad: StringEditor;
    Baja: BooleanEditor;
    IdProvincia: IntegerEditor;
    IdPais: IntegerEditor;
}

export class LocalidadesForm extends PrefixedContext {
    static formKey = 'Parametros.Localidades';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LocalidadesForm.init)  {
            LocalidadesForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;

            initFormType(LocalidadesForm, [
                'NombreLocalidad', w0,
                'Baja', w1,
                'IdProvincia', w2,
                'IdPais', w2
            ]);
        }
    }
}