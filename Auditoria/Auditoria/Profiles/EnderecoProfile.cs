using AutoMapper;
using SisClientes.DTOs;
using SisClientes.Models; 

namespace SisClientes.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<EnderecoDTO, Endereco>();
            CreateMap<Endereco, EnderecoDTO>();
        }
    }
}