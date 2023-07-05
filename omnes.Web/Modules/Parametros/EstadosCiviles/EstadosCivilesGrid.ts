import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EstadosCivilesColumns, EstadosCivilesRow, EstadosCivilesService } from '../../ServerTypes/Parametros';
import { EstadosCivilesDialog } from './EstadosCivilesDialog';

@Decorators.registerClass('omnes.Parametros.EstadosCivilesGrid')
export class EstadosCivilesGrid extends EntityGrid<EstadosCivilesRow, any> {
    protected getColumnsKey() { return EstadosCivilesColumns.columnsKey; }
    protected getDialogType() { return EstadosCivilesDialog; }
    protected getRowDefinition() { return EstadosCivilesRow; }
    protected getService() { return EstadosCivilesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}