import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TiposCuentasBancariaGrid } from './TiposCuentasBancariaGrid';

export default function pageInit() {
    initFullHeightGridPage(new TiposCuentasBancariaGrid($('#GridDiv')).element);
}