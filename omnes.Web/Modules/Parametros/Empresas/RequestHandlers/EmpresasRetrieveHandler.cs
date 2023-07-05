using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<omnes.Parametros.EmpresasRow>;
using MyRow = omnes.Parametros.EmpresasRow;

namespace omnes.Parametros;

public interface IEmpresasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasRetrieveHandler
{
    public EmpresasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}