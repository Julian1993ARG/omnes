import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CodigosPostalesColumns, CodigosPostalesRow, CodigosPostalesService } from '../../ServerTypes/Parametros';
import { CodigosPostalesDialog } from './CodigosPostalesDialog';

@Decorators.registerClass('omnes.Parametros.CodigosPostalesGrid')
export class CodigosPostalesGrid extends EntityGrid<CodigosPostalesRow, any> {
    protected getColumnsKey() { return CodigosPostalesColumns.columnsKey; }
    protected getDialogType() { return CodigosPostalesDialog; }
    protected getRowDefinition() { return CodigosPostalesRow; }
    protected getService() { return CodigosPostalesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}