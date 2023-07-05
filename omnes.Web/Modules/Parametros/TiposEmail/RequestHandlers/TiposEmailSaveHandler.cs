using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.TiposEmailRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.TiposEmailRow;

namespace omnes.Parametros;

public interface ITiposEmailSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposEmailSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposEmailSaveHandler
{
    public TiposEmailSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}