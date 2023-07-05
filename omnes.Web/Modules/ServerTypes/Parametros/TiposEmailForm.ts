import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TiposEmailForm {
    NombreTipoEmail: StringEditor;
}

export class TiposEmailForm extends PrefixedContext {
    static formKey = 'Parametros.TiposEmail';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TiposEmailForm.init)  {
            TiposEmailForm.init = true;

            var w0 = StringEditor;

            initFormType(TiposEmailForm, [
                'NombreTipoEmail', w0
            ]);
        }
    }
}