using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.CodigosPostalesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.CodigosPostalesRow;

namespace omnes.Parametros;

public interface ICodigosPostalesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CodigosPostalesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICodigosPostalesSaveHandler
{
    public CodigosPostalesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}