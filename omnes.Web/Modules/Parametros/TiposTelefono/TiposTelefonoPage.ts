import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TiposTelefonoGrid } from './TiposTelefonoGrid';

export default function pageInit() {
    initFullHeightGridPage(new TiposTelefonoGrid($('#GridDiv')).element);
}