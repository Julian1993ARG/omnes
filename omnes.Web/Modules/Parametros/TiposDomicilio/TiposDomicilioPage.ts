import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TiposDomicilioGrid } from './TiposDomicilioGrid';

export default function pageInit() {
    initFullHeightGridPage(new TiposDomicilioGrid($('#GridDiv')).element);
}