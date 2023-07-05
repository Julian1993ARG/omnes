import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TiposDomicilioForm {
    NombreTipoDomicilio: StringEditor;
}

export class TiposDomicilioForm extends PrefixedContext {
    static formKey = 'Parametros.TiposDomicilio';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TiposDomicilioForm.init)  {
            TiposDomicilioForm.init = true;

            var w0 = StringEditor;

            initFormType(TiposDomicilioForm, [
                'NombreTipoDomicilio', w0
            ]);
        }
    }
}