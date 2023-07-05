import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PaisesForm, PaisesRow, PaisesService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.PaisesDialog')
export class PaisesDialog extends EntityDialog<PaisesRow, any> {
    protected getFormKey() { return PaisesForm.formKey; }
    protected getRowDefinition() { return PaisesRow; }
    protected getService() { return PaisesService.baseUrl; }

    protected form = new PaisesForm(this.idPrefix);
}