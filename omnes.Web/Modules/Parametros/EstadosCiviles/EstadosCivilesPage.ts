import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { EstadosCivilesGrid } from './EstadosCivilesGrid';

export default function pageInit() {
    initFullHeightGridPage(new EstadosCivilesGrid($('#GridDiv')).element);
}