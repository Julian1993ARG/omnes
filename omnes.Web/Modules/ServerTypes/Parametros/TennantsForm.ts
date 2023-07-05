import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TennantsForm {
    Descripcion: StringEditor;
    Baja: BooleanEditor;
    Observaciones: StringEditor;
}

export class TennantsForm extends PrefixedContext {
    static formKey = 'Parametros.Tennants';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TennantsForm.init)  {
            TennantsForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(TennantsForm, [
                'Descripcion', w0,
                'Baja', w1,
                'Observaciones', w0
            ]);
        }
    }
}