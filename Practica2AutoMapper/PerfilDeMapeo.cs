using AutoMapper;
using Practica2AutoMapper.Models;

namespace Practica2AutoMapper
{
    public class PerfilDeMapeo : Profile
    {
        public PerfilDeMapeo()
        {
            CreateMap<Producto, ProductoDTO>();
        }
    }
}
