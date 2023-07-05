import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TiposCuentasBancariaColumns, TiposCuentasBancariaRow, TiposCuentasBancariaService } from '../../ServerTypes/Parametros';
import { TiposCuentasBancariaDialog } from './TiposCuentasBancariaDialog';

@Decorators.registerClass('omnes.Parametros.TiposCuentasBancariaGrid')
export class TiposCuentasBancariaGrid extends EntityGrid<TiposCuentasBancariaRow, any> {
    protected getColumnsKey() { return TiposCuentasBancariaColumns.columnsKey; }
    protected getDialogType() { return TiposCuentasBancariaDialog; }
    protected getRowDefinition() { return TiposCuentasBancariaRow; }
    protected getService() { return TiposCuentasBancariaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}