using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = omnes.Parametros.TiposDocumentoRow;

namespace omnes.Parametros;

public interface ITiposDocumentoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDocumentoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDocumentoDeleteHandler
{
    public TiposDocumentoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}