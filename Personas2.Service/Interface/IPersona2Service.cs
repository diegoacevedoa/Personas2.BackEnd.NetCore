using Personas2.Data.Models;
using Personas2.Domain.To.ViewModels;
using System.Collections.Generic;

namespace Personas2.Service.Interface
{
    public interface IPersona2Service
    {
        public List<Persona2> GetAll();

        public Persona2 GetById(int id);

        public List<Persona2> SearchAll(Persona2ViewModel persona);

        public int Save(Persona2 persona2);

        public bool Delete(int id);
    }
}
