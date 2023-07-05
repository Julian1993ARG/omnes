import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TiposEmailForm, TiposEmailRow, TiposEmailService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.TiposEmailDialog')
export class TiposEmailDialog extends EntityDialog<TiposEmailRow, any> {
    protected getFormKey() { return TiposEmailForm.formKey; }
    protected getRowDefinition() { return TiposEmailRow; }
    protected getService() { return TiposEmailService.baseUrl; }

    protected form = new TiposEmailForm(this.idPrefix);
}