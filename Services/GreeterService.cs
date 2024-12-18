using Grpc.Core;
using ClientegRPC;

namespace ClientegRPC.Services;

public class GreeterService : Greeter.GreeterBase
{
    public override Task<AgregarReply> AgregarCliente(AgregarRequest request, ServerCallContext context)
    {
        return Task.FromResult(new AgregarReply
        {
            Rut = request.Rut,
            Nombre = request.Nombre,
            Apellido = request.Apellido
        });
    }

    public override Task<ReservaReply> Reservar(ReservaRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ReservaReply
        {
            IdCliente = request.IdCliente,
            Dias = request.Dias
        });
    }
}
