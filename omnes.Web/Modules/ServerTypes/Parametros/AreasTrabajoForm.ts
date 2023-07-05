import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AreasTrabajoForm {
    IdTennant: IntegerEditor;
    IdEmpresa: IntegerEditor;
    Descripcion: StringEditor;
    Baja: BooleanEditor;
}

export class AreasTrabajoForm extends PrefixedContext {
    static formKey = 'Parametros.AreasTrabajo';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AreasTrabajoForm.init)  {
            AreasTrabajoForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(AreasTrabajoForm, [
                'IdTennant', w0,
                'IdEmpresa', w0,
                'Descripcion', w1,
                'Baja', w2
            ]);
        }
    }
}