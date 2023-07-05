import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EtiquetasForm, EtiquetasRow, EtiquetasService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.EtiquetasDialog')
export class EtiquetasDialog extends EntityDialog<EtiquetasRow, any> {
    protected getFormKey() { return EtiquetasForm.formKey; }
    protected getRowDefinition() { return EtiquetasRow; }
    protected getService() { return EtiquetasService.baseUrl; }

    protected form = new EtiquetasForm(this.idPrefix);
}