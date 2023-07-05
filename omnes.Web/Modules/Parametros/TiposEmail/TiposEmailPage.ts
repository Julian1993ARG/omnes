import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TiposEmailGrid } from './TiposEmailGrid';

export default function pageInit() {
    initFullHeightGridPage(new TiposEmailGrid($('#GridDiv')).element);
}