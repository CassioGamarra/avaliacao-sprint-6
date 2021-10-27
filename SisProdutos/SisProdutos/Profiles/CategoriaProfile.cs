using AutoMapper;
using SisProdutos.DTOs;
using SisProdutos.Models;

namespace SisProdutos.Profiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CategoriaDTO, Categoria>();
            CreateMap<Categoria, CategoriaDTO>();
        }
    }
}