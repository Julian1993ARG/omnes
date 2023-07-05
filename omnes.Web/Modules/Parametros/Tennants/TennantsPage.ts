import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TennantsGrid } from './TennantsGrid';

export default function pageInit() {
    initFullHeightGridPage(new TennantsGrid($('#GridDiv')).element);
}