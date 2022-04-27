using Personas2.Domain.To.ViewModels;
using System.Collections.Generic;

namespace Personas2.Service.Interface
{
    public interface IEnumsService
    {
        public IEnumerable<EnumViewModel> GetEnumTipoDocumento();
    }
}
