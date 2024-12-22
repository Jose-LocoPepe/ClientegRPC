using Grpc.Core;
using ClientegRPC;
using ClientegRPC.Models;
namespace ClientegRPC.Services;

public class GreeterService : Greeter.GreeterBase
{
    // Esto debería ir en el repositorio de ServidorgRPC
    // public override Task<AgregarReply> AgregarCliente(AgregarRequest request, ServerCallContext context)
    // {
    //     // Aquí se puede agregar la lógica para agregar el cliente a la base de datos
    //     return Task.FromResult(new AgregarReply
    //     {
    //         Message = "Cliente added successfully!"
    //     });
    // }

    public override Task<ReservaReply> Reservar(ReservaRequest request, ServerCallContext context)
    {
        ClientesContext clientesContext = new();
        var cliente = clientesContext.Clientes.Find(request.IdCliente);

        if (cliente == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "Cliente no encontrado"));
        }

        cliente.Dias = request.Dias;
        clientesContext.SaveChanges();

        return Task.FromResult(new ReservaReply
        {
            Message = "Cliente actualizado exitosamente!"
        });
    }
}
