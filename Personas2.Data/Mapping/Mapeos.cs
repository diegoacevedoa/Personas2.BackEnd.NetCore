using AutoMapper;
using Personas2.Data.Models;
using Personas2.Domain.To.ViewModels;

namespace Personas2.Data.Mapping
{
    public class Mapeos : Profile
    {
        public Mapeos()
        {
            #region Personas

            CreateMap<Persona2, Persona2ViewModel>()
               .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
               .ForMember(m => m.Activo, map => map.MapFrom(vm => vm.Activo))
               .ForMember(m => m.Eliminado, map => map.MapFrom(vm => vm.Eliminado))
               .ForMember(m => m.UsuarioRegistro, map => map.MapFrom(vm => vm.UsuarioRegistro))
               .ForMember(m => m.UsuarioModifica, map => map.MapFrom(vm => vm.UsuarioModifica))
               .ForMember(m => m.UsuarioElimina, map => map.MapFrom(vm => vm.UsuarioElimina))
               .ForMember(m => m.FechaRegistro, map => map.MapFrom(vm => vm.FechaRegistro))
               .ForMember(m => m.FechaModificado, map => map.MapFrom(vm => vm.FechaModificado))
               .ForMember(m => m.FechaEliminado, map => map.MapFrom(vm => vm.FechaEliminado))
               .ForMember(m => m.Nombres, map => map.MapFrom(vm => vm.Nombres))
               .ForMember(m => m.Apellidos, map => map.MapFrom(vm => vm.Apellidos))
               .ForMember(m => m.TipoDocumento, map => map.MapFrom(vm => vm.TipoDocumento))
               .ForMember(m => m.NoDocumento, map => map.MapFrom(vm => vm.NoDocumento))
               .ForMember(m => m.FechaNacimiento, map => map.MapFrom(vm => vm.FechaNacimiento))
               .ForMember(m => m.NoContacto, map => map.MapFrom(vm => vm.NoContacto))
               .ForMember(m => m.Email, map => map.MapFrom(vm => vm.Email))
               .ForMember(m => m.Direccion, map => map.MapFrom(vm => vm.Direccion))
               .ReverseMap();

            #endregion
        }
    }
}
