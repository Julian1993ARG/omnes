using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.TennantsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.TennantsRow;

namespace omnes.Parametros;

public interface ITennantsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TennantsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITennantsSaveHandler
{
    public TennantsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}