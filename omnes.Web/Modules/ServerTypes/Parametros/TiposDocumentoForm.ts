import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TiposDocumentoForm {
    NombreTipoDocumento: StringEditor;
    Baja: BooleanEditor;
    Sigla: StringEditor;
}

export class TiposDocumentoForm extends PrefixedContext {
    static formKey = 'Parametros.TiposDocumento';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TiposDocumentoForm.init)  {
            TiposDocumentoForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(TiposDocumentoForm, [
                'NombreTipoDocumento', w0,
                'Baja', w1,
                'Sigla', w0
            ]);
        }
    }
}