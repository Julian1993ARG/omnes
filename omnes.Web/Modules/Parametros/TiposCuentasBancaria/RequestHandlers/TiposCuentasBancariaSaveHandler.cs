using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.TiposCuentasBancariaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.TiposCuentasBancariaRow;

namespace omnes.Parametros;

public interface ITiposCuentasBancariaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposCuentasBancariaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposCuentasBancariaSaveHandler
{
    public TiposCuentasBancariaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}