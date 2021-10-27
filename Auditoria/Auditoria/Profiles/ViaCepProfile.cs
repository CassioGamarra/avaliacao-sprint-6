using AutoMapper;
using SisClientes.DTOs;
using SisClientes.Models;

namespace SisClientes.Profiles
{
    public class ViaCepProfile : Profile
    {
        public ViaCepProfile()
        {
            CreateMap<ViaCepDTO, ViaCep>();
            CreateMap<ViaCep, ViaCepDTO>();
        } 
    }
}