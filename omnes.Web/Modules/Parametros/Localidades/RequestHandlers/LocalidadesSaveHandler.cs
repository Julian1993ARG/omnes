using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.LocalidadesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.LocalidadesRow;

namespace omnes.Parametros;

public interface ILocalidadesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class LocalidadesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILocalidadesSaveHandler
{
    public LocalidadesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}