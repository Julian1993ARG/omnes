import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CodigosPostalesForm, CodigosPostalesRow, CodigosPostalesService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('omnes.Parametros.CodigosPostalesDialog')
export class CodigosPostalesDialog extends EntityDialog<CodigosPostalesRow, any> {
    protected getFormKey() { return CodigosPostalesForm.formKey; }
    protected getRowDefinition() { return CodigosPostalesRow; }
    protected getService() { return CodigosPostalesService.baseUrl; }

    protected form = new CodigosPostalesForm(this.idPrefix);
}