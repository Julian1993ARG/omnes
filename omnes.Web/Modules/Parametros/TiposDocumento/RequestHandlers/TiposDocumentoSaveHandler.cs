using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.TiposDocumentoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.TiposDocumentoRow;

namespace omnes.Parametros;

public interface ITiposDocumentoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDocumentoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDocumentoSaveHandler
{
    public TiposDocumentoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}