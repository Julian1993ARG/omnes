import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AreasTrabajoForm, AreasTrabajoRow, AreasTrabajoService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.AreasTrabajoDialog')
export class AreasTrabajoDialog extends EntityDialog<AreasTrabajoRow, any> {
    protected getFormKey() { return AreasTrabajoForm.formKey; }
    protected getRowDefinition() { return AreasTrabajoRow; }
    protected getService() { return AreasTrabajoService.baseUrl; }

    protected form = new AreasTrabajoForm(this.idPrefix);
}