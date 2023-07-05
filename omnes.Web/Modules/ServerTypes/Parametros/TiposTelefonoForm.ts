import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TiposTelefonoForm {
    NombreTipoTelefono: StringEditor;
}

export class TiposTelefonoForm extends PrefixedContext {
    static formKey = 'Parametros.TiposTelefono';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TiposTelefonoForm.init)  {
            TiposTelefonoForm.init = true;

            var w0 = StringEditor;

            initFormType(TiposTelefonoForm, [
                'NombreTipoTelefono', w0
            ]);
        }
    }
}