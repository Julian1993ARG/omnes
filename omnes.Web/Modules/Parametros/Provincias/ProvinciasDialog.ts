import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProvinciasForm, ProvinciasRow, ProvinciasService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.ProvinciasDialog')
export class ProvinciasDialog extends EntityDialog<ProvinciasRow, any> {
    protected getFormKey() { return ProvinciasForm.formKey; }
    protected getRowDefinition() { return ProvinciasRow; }
    protected getService() { return ProvinciasService.baseUrl; }

    protected form = new ProvinciasForm(this.idPrefix);
}