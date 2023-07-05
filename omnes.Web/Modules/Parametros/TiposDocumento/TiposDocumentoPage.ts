import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TiposDocumentoGrid } from './TiposDocumentoGrid';

export default function pageInit() {
    initFullHeightGridPage(new TiposDocumentoGrid($('#GridDiv')).element);
}