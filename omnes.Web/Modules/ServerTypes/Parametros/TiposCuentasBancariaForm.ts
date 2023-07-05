import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TiposCuentasBancariaForm {
    Descripcion: StringEditor;
    Baja: BooleanEditor;
    Observaciones: StringEditor;
}

export class TiposCuentasBancariaForm extends PrefixedContext {
    static formKey = 'Parametros.TiposCuentasBancaria';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TiposCuentasBancariaForm.init)  {
            TiposCuentasBancariaForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(TiposCuentasBancariaForm, [
                'Descripcion', w0,
                'Baja', w1,
                'Observaciones', w0
            ]);
        }
    }
}