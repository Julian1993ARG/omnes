import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LocalidadesColumns, LocalidadesRow, LocalidadesService } from '../../ServerTypes/Parametros';
import { LocalidadesDialog } from './LocalidadesDialog';

@Decorators.registerClass('omnes.Parametros.LocalidadesGrid')
export class LocalidadesGrid extends EntityGrid<LocalidadesRow, any> {
    protected getColumnsKey() { return LocalidadesColumns.columnsKey; }
    protected getDialogType() { return LocalidadesDialog; }
    protected getRowDefinition() { return LocalidadesRow; }
    protected getService() { return LocalidadesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}