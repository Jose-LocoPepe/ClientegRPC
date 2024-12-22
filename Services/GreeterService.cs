using Grpc.Core;
using ClientegRPC;

namespace ClientegRPC.Services;

public class GreeterService : Greeter.GreeterBase
{
    public override Task<AgregarReply> AgregarCliente(AgregarRequest request, ServerCallContext context)
    {
        // Aquí se puede agregar la lógica para agregar el cliente a la base de datos

        return Task.FromResult(new AgregarReply
        {
            Message = "Cliente added successfully!"
        });


    }

    public override Task<ReservaReply> Reservar(ReservaRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ReservaReply
        {
            
        });


    }
}
