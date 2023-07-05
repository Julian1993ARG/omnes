import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProvinciasGrid } from './ProvinciasGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProvinciasGrid($('#GridDiv')).element);
}