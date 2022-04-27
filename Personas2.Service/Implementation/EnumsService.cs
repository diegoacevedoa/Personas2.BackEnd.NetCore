using Personas2.Domain.To.Helpers;
using Personas2.Domain.To.ViewModels;
using Personas2.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Personas2.Service.Implementation
{
    public class EnumsService: IEnumsService
    {
        public IEnumerable<EnumViewModel> GetEnumTipoDocumento()
        {
            var enumTipoDocumento = (from EnumTipoDocumento e in Enum.GetValues(typeof(EnumTipoDocumento))
                                     select new EnumViewModel { Id = (int)e, Nombre = e.ToString() });

            return enumTipoDocumento;
        }
    }
}
