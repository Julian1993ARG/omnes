import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PaisesColumns, PaisesRow, PaisesService } from '../../ServerTypes/Parametros';
import { PaisesDialog } from './PaisesDialog';

@Decorators.registerClass('omnes.Parametros.PaisesGrid')
export class PaisesGrid extends EntityGrid<PaisesRow, any> {
    protected getColumnsKey() { return PaisesColumns.columnsKey; }
    protected getDialogType() { return PaisesDialog; }
    protected getRowDefinition() { return PaisesRow; }
    protected getService() { return PaisesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}