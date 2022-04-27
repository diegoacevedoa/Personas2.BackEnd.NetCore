using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Personas2.Service.Interface;

namespace Personas2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        private readonly IEnumsService _IEnumsService;

        public EnumsController(IEnumsService iEnumsService)
        {
            _IEnumsService = iEnumsService;
        }

        [HttpGet]
        [Route(nameof(GetEnumTipoDocumento))]
        public JsonResult GetEnumTipoDocumento()
        {
            var data = _IEnumsService.GetEnumTipoDocumento();

            return new JsonResult(data);
        }
    }
}
