import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TiposCuentasBancariaForm, TiposCuentasBancariaRow, TiposCuentasBancariaService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.TiposCuentasBancariaDialog')
export class TiposCuentasBancariaDialog extends EntityDialog<TiposCuentasBancariaRow, any> {
    protected getFormKey() { return TiposCuentasBancariaForm.formKey; }
    protected getRowDefinition() { return TiposCuentasBancariaRow; }
    protected getService() { return TiposCuentasBancariaService.baseUrl; }

    protected form = new TiposCuentasBancariaForm(this.idPrefix);
}