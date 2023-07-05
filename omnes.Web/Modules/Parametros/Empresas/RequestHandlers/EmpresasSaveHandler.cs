using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<omnes.Parametros.EmpresasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = omnes.Parametros.EmpresasRow;

namespace omnes.Parametros;

public interface IEmpresasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasSaveHandler
{
    public EmpresasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}