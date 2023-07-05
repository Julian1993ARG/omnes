import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EstadosCivilesForm, EstadosCivilesRow, EstadosCivilesService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.EstadosCivilesDialog')
export class EstadosCivilesDialog extends EntityDialog<EstadosCivilesRow, any> {
    protected getFormKey() { return EstadosCivilesForm.formKey; }
    protected getRowDefinition() { return EstadosCivilesRow; }
    protected getService() { return EstadosCivilesService.baseUrl; }

    protected form = new EstadosCivilesForm(this.idPrefix);
}