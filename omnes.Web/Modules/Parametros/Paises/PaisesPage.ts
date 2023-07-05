import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PaisesGrid } from './PaisesGrid';

export default function pageInit() {
    initFullHeightGridPage(new PaisesGrid($('#GridDiv')).element);
}