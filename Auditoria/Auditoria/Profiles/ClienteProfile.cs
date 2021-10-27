using AutoMapper;
using SisClientes.DTOs;
using SisClientes.Models;

namespace SisClientes.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Cliente, ClienteDTO>();
        }
    }
}