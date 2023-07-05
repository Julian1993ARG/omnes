import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TiposTelefonoForm, TiposTelefonoRow, TiposTelefonoService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.TiposTelefonoDialog')
export class TiposTelefonoDialog extends EntityDialog<TiposTelefonoRow, any> {
    protected getFormKey() { return TiposTelefonoForm.formKey; }
    protected getRowDefinition() { return TiposTelefonoRow; }
    protected getService() { return TiposTelefonoService.baseUrl; }

    protected form = new TiposTelefonoForm(this.idPrefix);
}