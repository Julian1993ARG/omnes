import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TiposTelefonoColumns, TiposTelefonoRow, TiposTelefonoService } from '../../ServerTypes/Parametros';
import { TiposTelefonoDialog } from './TiposTelefonoDialog';

@Decorators.registerClass('omnes.Parametros.TiposTelefonoGrid')
export class TiposTelefonoGrid extends EntityGrid<TiposTelefonoRow, any> {
    protected getColumnsKey() { return TiposTelefonoColumns.columnsKey; }
    protected getDialogType() { return TiposTelefonoDialog; }
    protected getRowDefinition() { return TiposTelefonoRow; }
    protected getService() { return TiposTelefonoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}