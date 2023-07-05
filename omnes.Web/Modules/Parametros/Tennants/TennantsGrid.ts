import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TennantsColumns, TennantsRow, TennantsService } from '../../ServerTypes/Parametros';
import { TennantsDialog } from './TennantsDialog';

@Decorators.registerClass('omnes.Parametros.TennantsGrid')
export class TennantsGrid extends EntityGrid<TennantsRow, any> {
    protected getColumnsKey() { return TennantsColumns.columnsKey; }
    protected getDialogType() { return TennantsDialog; }
    protected getRowDefinition() { return TennantsRow; }
    protected getService() { return TennantsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}