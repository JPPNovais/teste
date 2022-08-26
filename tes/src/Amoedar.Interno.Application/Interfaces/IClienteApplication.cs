using Amoedar.Interno.Application.Models;
using Amoedar.Interno.Domain.Entities;

namespace Amoedar.Interno.Application.Interfaces
{
    public interface IClienteApplication
    {
        Result<Cliente> Salvar(ClienteModel clienteModel);
    }
}