using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Personas2.Data.Models;
using Personas2.Domain.To.ViewModels;
using Personas2.Service.Interface;
using System.Collections.Generic;

namespace Personas2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Personas2Controller : ControllerBase
    {
        private readonly IPersona2Service _IPersona2Service;
        private readonly IMapper _IMapper;

        public Personas2Controller(IPersona2Service iPersona2Service, IMapper iMapper)
        {
            _IPersona2Service = iPersona2Service;
            _IMapper = iMapper;
        }

        // GET: api/Personas2
        [HttpGet]
        [Route(nameof(GetAllPersonas))]
        public JsonResult GetAllPersonas()
        {
            var data = _IPersona2Service.GetAll();
            var mapped = _IMapper.Map<List<Persona2>, List<Persona2ViewModel>>(data);

            return new JsonResult(mapped);
        }

        [HttpPost]
        [Route(nameof(SearchAllPersonas))]
        public JsonResult SearchAllPersonas([FromBody] Persona2ViewModel viewModel)
        {
            var data = _IPersona2Service.SearchAll(viewModel);
            var mapped = _IMapper.Map<List<Persona2>, List<Persona2ViewModel>>(data);

            return new JsonResult(mapped);
        }

        [HttpPost]
        [Route(nameof(SavePersona))]
        public JsonResult SavePersona([FromBody]  Persona2ViewModel viewModel)
        {
            var mapped = _IMapper.Map<Persona2ViewModel, Persona2>(viewModel);

            var data = _IPersona2Service.Save(mapped);

            return new JsonResult(data);
        }

        [HttpPost]
        [Route(nameof(DeletePersona))]
        public JsonResult DeletePersona([FromBody] int id)
        {            
            var data = _IPersona2Service.Delete(id);

            return new JsonResult(data);
        }
    }
}
