import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TennantsForm, TennantsRow, TennantsService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.TennantsDialog')
export class TennantsDialog extends EntityDialog<TennantsRow, any> {
    protected getFormKey() { return TennantsForm.formKey; }
    protected getRowDefinition() { return TennantsRow; }
    protected getService() { return TennantsService.baseUrl; }

    protected form = new TennantsForm(this.idPrefix);
}