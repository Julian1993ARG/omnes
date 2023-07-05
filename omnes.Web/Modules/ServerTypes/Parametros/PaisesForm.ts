import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface PaisesForm {
    NombrePais: StringEditor;
    Baja: BooleanEditor;
}

export class PaisesForm extends PrefixedContext {
    static formKey = 'Parametros.Paises';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PaisesForm.init)  {
            PaisesForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(PaisesForm, [
                'NombrePais', w0,
                'Baja', w1
            ]);
        }
    }
}