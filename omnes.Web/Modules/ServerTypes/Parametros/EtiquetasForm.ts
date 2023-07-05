import { StringEditor, BooleanEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EtiquetasForm {
    Descripcion: StringEditor;
    Baja: BooleanEditor;
    Observaciones: StringEditor;
    IdTennant: IntegerEditor;
}

export class EtiquetasForm extends PrefixedContext {
    static formKey = 'Parametros.Etiquetas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EtiquetasForm.init)  {
            EtiquetasForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;

            initFormType(EtiquetasForm, [
                'Descripcion', w0,
                'Baja', w1,
                'Observaciones', w0,
                'IdTennant', w2
            ]);
        }
    }
}