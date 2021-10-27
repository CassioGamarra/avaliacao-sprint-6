using AutoMapper;
using SisProdutos.DTOs;
using SisProdutos.Models;

namespace SisProdutos.Profiles
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