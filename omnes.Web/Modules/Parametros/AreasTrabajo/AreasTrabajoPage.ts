import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AreasTrabajoGrid } from './AreasTrabajoGrid';

export default function pageInit() {
    initFullHeightGridPage(new AreasTrabajoGrid($('#GridDiv')).element);
}