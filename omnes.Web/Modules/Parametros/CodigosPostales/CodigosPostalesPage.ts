import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CodigosPostalesGrid } from './CodigosPostalesGrid';

export default function pageInit() {
    initFullHeightGridPage(new CodigosPostalesGrid($('#GridDiv')).element);
}