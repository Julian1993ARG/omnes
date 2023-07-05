import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EstadosCivilesForm {
    DescripcionEstadoCivil: StringEditor;
    Baja: BooleanEditor;
}

export class EstadosCivilesForm extends PrefixedContext {
    static formKey = 'Parametros.EstadosCiviles';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EstadosCivilesForm.init)  {
            EstadosCivilesForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(EstadosCivilesForm, [
                'DescripcionEstadoCivil', w0,
                'Baja', w1
            ]);
        }
    }
}