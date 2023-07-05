import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { LocalidadesGrid } from './LocalidadesGrid';

export default function pageInit() {
    initFullHeightGridPage(new LocalidadesGrid($('#GridDiv')).element);
}