using AutoMapper;
using SisProdutos.DTOs;
using SisProdutos.Models;

namespace SisProdutos.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}