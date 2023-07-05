import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { LocalidadesForm, LocalidadesRow, LocalidadesService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.LocalidadesDialog')
export class LocalidadesDialog extends EntityDialog<LocalidadesRow, any> {
    protected getFormKey() { return LocalidadesForm.formKey; }
    protected getRowDefinition() { return LocalidadesRow; }
    protected getService() { return LocalidadesService.baseUrl; }

    protected form = new LocalidadesForm(this.idPrefix);
}