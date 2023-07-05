import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EtiquetasColumns, EtiquetasRow, EtiquetasService } from '../../ServerTypes/Parametros';
import { EtiquetasDialog } from './EtiquetasDialog';

@Decorators.registerClass('omnes.Parametros.EtiquetasGrid')
export class EtiquetasGrid extends EntityGrid<EtiquetasRow, any> {
    protected getColumnsKey() { return EtiquetasColumns.columnsKey; }
    protected getDialogType() { return EtiquetasDialog; }
    protected getRowDefinition() { return EtiquetasRow; }
    protected getService() { return EtiquetasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}