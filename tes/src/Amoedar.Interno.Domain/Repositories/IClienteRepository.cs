using Amoedar.Interno.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Amoedar.Interno.Domain.Repositories
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ListarTodos();
    }
}
