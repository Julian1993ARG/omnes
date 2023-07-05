import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TiposDomicilioColumns, TiposDomicilioRow, TiposDomicilioService } from '../../ServerTypes/Parametros';
import { TiposDomicilioDialog } from './TiposDomicilioDialog';

@Decorators.registerClass('omnes.Parametros.TiposDomicilioGrid')
export class TiposDomicilioGrid extends EntityGrid<TiposDomicilioRow, any> {
    protected getColumnsKey() { return TiposDomicilioColumns.columnsKey; }
    protected getDialogType() { return TiposDomicilioDialog; }
    protected getRowDefinition() { return TiposDomicilioRow; }
    protected getService() { return TiposDomicilioService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}