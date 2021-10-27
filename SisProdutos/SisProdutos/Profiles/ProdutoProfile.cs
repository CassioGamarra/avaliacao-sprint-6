using AutoMapper;
using SisProdutos.DTOs;
using SisProdutos.Models;

namespace SisProdutos.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoDTO, Produto>();
            CreateMap<Produto, ProdutoDTO>();
        }
    }
}