using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.TiposDomicilioRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.TiposDomicilioRow;

namespace omnes.Parametros;

public interface ITiposDomicilioSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposDomicilioSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposDomicilioSaveHandler
{
    public TiposDomicilioSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}