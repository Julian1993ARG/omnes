import { StringEditor, BooleanEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProvinciasForm {
    NombreProvincia: StringEditor;
    Baja: BooleanEditor;
    IdPais: IntegerEditor;
}

export class ProvinciasForm extends PrefixedContext {
    static formKey = 'Parametros.Provincias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProvinciasForm.init)  {
            ProvinciasForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;

            initFormType(ProvinciasForm, [
                'NombreProvincia', w0,
                'Baja', w1,
                'IdPais', w2
            ]);
        }
    }
}