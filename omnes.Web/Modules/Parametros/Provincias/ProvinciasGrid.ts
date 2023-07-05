import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProvinciasColumns, ProvinciasRow, ProvinciasService } from '../../ServerTypes/Parametros';
import { ProvinciasDialog } from './ProvinciasDialog';

@Decorators.registerClass('omnes.Parametros.ProvinciasGrid')
export class ProvinciasGrid extends EntityGrid<ProvinciasRow, any> {
    protected getColumnsKey() { return ProvinciasColumns.columnsKey; }
    protected getDialogType() { return ProvinciasDialog; }
    protected getRowDefinition() { return ProvinciasRow; }
    protected getService() { return ProvinciasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}