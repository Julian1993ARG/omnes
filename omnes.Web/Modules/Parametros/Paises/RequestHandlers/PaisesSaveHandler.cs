using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.PaisesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.PaisesRow;

namespace omnes.Parametros;

public interface IPaisesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PaisesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPaisesSaveHandler
{
    public PaisesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}