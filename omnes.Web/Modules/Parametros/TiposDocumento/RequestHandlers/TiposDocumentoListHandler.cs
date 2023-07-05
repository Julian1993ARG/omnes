using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<omnes.Parametros.TiposDocumentoRow>;
using MyRow = omnes.Parametros.TiposDocumentoRow;

namespace omnes.Parametros;

public interface ITiposDocumentoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDocumentoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDocumentoListHandler
{
    public TiposDocumentoListHandler(IRequestContext context)
            : base(context)
    {
    }
}