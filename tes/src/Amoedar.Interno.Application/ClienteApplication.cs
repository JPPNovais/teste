using AutoMapper;
using Amoedar.Interno.Application.Interfaces;
using Amoedar.Interno.Application.Models;
using Amoedar.Interno.Domain.Entities;
using Amoedar.Interno.Domain.Repositories;

namespace Amoedar.Interno.Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ClienteApplication(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public Result<Cliente> Salvar(ClienteModel clienteModel)
        {
            var cliente = _mapper.Map<ClienteModel, Cliente>(clienteModel);

            if (cliente.Valid)
            {
                _clienteRepository.Incluir(cliente);
                return Result<Cliente>.Ok(cliente);
            }

            return Result<Cliente>.Error(cliente.Notifications);
        }
    }
}
