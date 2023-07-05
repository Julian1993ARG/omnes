using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.EtiquetasRow;

namespace omnes.Parametros;

public interface IEtiquetasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EtiquetasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEtiquetasDeleteHandler
{
    public EtiquetasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}