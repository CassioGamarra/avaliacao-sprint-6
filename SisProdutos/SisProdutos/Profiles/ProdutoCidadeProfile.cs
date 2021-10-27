using AutoMapper;
using SisProdutos.DTOs;
using SisProdutos.Models;

namespace SisProdutos.Profiles
{
    public class ProdutoCidadeProfile : Profile
    {
        public ProdutoCidadeProfile()
        {
            CreateMap<ProdutoCidadeDTO, ProdutoCidade>();
            CreateMap<ProdutoCidade, ProdutoCidadeDTO>();
        }
    }
}