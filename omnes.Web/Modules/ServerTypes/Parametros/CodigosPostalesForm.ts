import { StringEditor, BooleanEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CodigosPostalesForm {
    CodPostal: StringEditor;
    Baja: BooleanEditor;
    IdLocalidad: IntegerEditor;
    IdProvincia: IntegerEditor;
    IdPais: IntegerEditor;
}

export class CodigosPostalesForm extends PrefixedContext {
    static formKey = 'Parametros.CodigosPostales';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CodigosPostalesForm.init)  {
            CodigosPostalesForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;

            initFormType(CodigosPostalesForm, [
                'CodPostal', w0,
                'Baja', w1,
                'IdLocalidad', w2,
                'IdProvincia', w2,
                'IdPais', w2
            ]);
        }
    }
}