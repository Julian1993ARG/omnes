import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TiposDomicilioRow } from "./TiposDomicilioRow";

export namespace TiposDomicilioService {
    export const baseUrl = 'Parametros/TiposDomicilio';

    export declare function Create(request: SaveRequest<TiposDomicilioRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TiposDomicilioRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TiposDomicilioRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TiposDomicilioRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Parametros/TiposDomicilio/Create",
        Update: "Parametros/TiposDomicilio/Update",
        Delete: "Parametros/TiposDomicilio/Delete",
        Retrieve: "Parametros/TiposDomicilio/Retrieve",
        List: "Parametros/TiposDomicilio/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TiposDomicilioService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}