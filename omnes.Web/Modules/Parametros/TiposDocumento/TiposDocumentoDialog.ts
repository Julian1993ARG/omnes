import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TiposDocumentoForm, TiposDocumentoRow, TiposDocumentoService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.TiposDocumentoDialog')
export class TiposDocumentoDialog extends EntityDialog<TiposDocumentoRow, any> {
    protected getFormKey() { return TiposDocumentoForm.formKey; }
    protected getRowDefinition() { return TiposDocumentoRow; }
    protected getService() { return TiposDocumentoService.baseUrl; }

    protected form = new TiposDocumentoForm(this.idPrefix);
}