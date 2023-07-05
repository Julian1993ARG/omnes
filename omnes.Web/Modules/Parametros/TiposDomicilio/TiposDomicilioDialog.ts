import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TiposDomicilioForm, TiposDomicilioRow, TiposDomicilioService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.TiposDomicilioDialog')
export class TiposDomicilioDialog extends EntityDialog<TiposDomicilioRow, any> {
    protected getFormKey() { return TiposDomicilioForm.formKey; }
    protected getRowDefinition() { return TiposDomicilioRow; }
    protected getService() { return TiposDomicilioService.baseUrl; }

    protected form = new TiposDomicilioForm(this.idPrefix);
}