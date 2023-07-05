import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TiposEmailColumns, TiposEmailRow, TiposEmailService } from '../../ServerTypes/Parametros';
import { TiposEmailDialog } from './TiposEmailDialog';

@Decorators.registerClass('omnes.Parametros.TiposEmailGrid')
export class TiposEmailGrid extends EntityGrid<TiposEmailRow, any> {
    protected getColumnsKey() { return TiposEmailColumns.columnsKey; }
    protected getDialogType() { return TiposEmailDialog; }
    protected getRowDefinition() { return TiposEmailRow; }
    protected getService() { return TiposEmailService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}