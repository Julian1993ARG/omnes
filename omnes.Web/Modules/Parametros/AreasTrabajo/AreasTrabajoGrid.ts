import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AreasTrabajoColumns, AreasTrabajoRow, AreasTrabajoService } from '../../ServerTypes/Parametros';
import { AreasTrabajoDialog } from './AreasTrabajoDialog';

@Decorators.registerClass('omnes.Parametros.AreasTrabajoGrid')
export class AreasTrabajoGrid extends EntityGrid<AreasTrabajoRow, any> {
    protected getColumnsKey() { return AreasTrabajoColumns.columnsKey; }
    protected getDialogType() { return AreasTrabajoDialog; }
    protected getRowDefinition() { return AreasTrabajoRow; }
    protected getService() { return AreasTrabajoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}