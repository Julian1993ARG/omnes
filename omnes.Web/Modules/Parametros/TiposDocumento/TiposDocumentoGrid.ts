import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TiposDocumentoColumns, TiposDocumentoRow, TiposDocumentoService } from '../../ServerTypes/Parametros';
import { TiposDocumentoDialog } from './TiposDocumentoDialog';

@Decorators.registerClass('omnes.Parametros.TiposDocumentoGrid')
export class TiposDocumentoGrid extends EntityGrid<TiposDocumentoRow, any> {
    protected getColumnsKey() { return TiposDocumentoColumns.columnsKey; }
    protected getDialogType() { return TiposDocumentoDialog; }
    protected getRowDefinition() { return TiposDocumentoRow; }
    protected getService() { return TiposDocumentoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}