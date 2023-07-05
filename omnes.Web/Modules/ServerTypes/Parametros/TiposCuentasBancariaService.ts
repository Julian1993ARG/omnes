import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TiposCuentasBancariaRow } from "./TiposCuentasBancariaRow";

export namespace TiposCuentasBancariaService {
    export const baseUrl = 'Parametros/TiposCuentasBancaria';

    export declare function Create(request: SaveRequest<TiposCuentasBancariaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TiposCuentasBancariaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TiposCuentasBancariaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TiposCuentasBancariaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Parametros/TiposCuentasBancaria/Create",
        Update: "Parametros/TiposCuentasBancaria/Update",
        Delete: "Parametros/TiposCuentasBancaria/Delete",
        Retrieve: "Parametros/TiposCuentasBancaria/Retrieve",
        List: "Parametros/TiposCuentasBancaria/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TiposCuentasBancariaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}