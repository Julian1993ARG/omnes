using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.ProvinciasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.ProvinciasRow;

namespace omnes.Parametros;

public interface IProvinciasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProvinciasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProvinciasSaveHandler
{
    public ProvinciasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}