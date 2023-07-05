using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.TiposTelefonoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.TiposTelefonoRow;

namespace omnes.Parametros;

public interface ITiposTelefonoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposTelefonoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposTelefonoSaveHandler
{
    public TiposTelefonoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}