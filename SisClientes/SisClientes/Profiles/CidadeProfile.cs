using AutoMapper;
using SisClientes.DTOs;
using SisClientes.Models;

namespace SisClientes.Profiles
{
    public class CidadeProfile : Profile
    {
        public CidadeProfile()
        {
            CreateMap<CidadeDTO, Cidade>();
            CreateMap<Cidade, CidadeDTO>();
        }
    }
}