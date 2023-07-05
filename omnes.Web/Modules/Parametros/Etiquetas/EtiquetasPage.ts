import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { EtiquetasGrid } from './EtiquetasGrid';

export default function pageInit() {
    initFullHeightGridPage(new EtiquetasGrid($('#GridDiv')).element);
}