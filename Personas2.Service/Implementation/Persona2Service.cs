using Microsoft.EntityFrameworkCore;
using Personas2.Data.Context;
using Personas2.Data.Models;
using Personas2.Domain.To.ViewModels;
using Personas2.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Personas2.Service.Implementation
{
    public class Persona2Service : IPersona2Service
    {
        private readonly Personas2Context _Personas2Context;

        public Persona2Service(Personas2Context context)
        {
            _Personas2Context = context;
        }

        public List<Persona2> GetAll()
        {
            return _Personas2Context.Persona2.Where(x => x.Eliminado == false).OrderBy(x => x.Id).ToList();
        }

        public Persona2 GetById(int id)
        {
            return _Personas2Context.Persona2.Where(x => x.Eliminado == false && x.Id == id).FirstOrDefault();
        }

        public List<Persona2> SearchAll(Persona2ViewModel persona)
        {
            var query = _Personas2Context.Persona2.AsNoTracking().Where(x => x.Eliminado == false);

            if (!string.IsNullOrEmpty(persona.Nombres))
            {
                query = query.Where(x => x.Nombres.Contains(persona.Nombres));
            }

            if (!string.IsNullOrEmpty(persona.NoDocumento))
            {
                query = query.Where(x => x.NoDocumento == persona.NoDocumento);
            }

            var data = query.OrderBy(x => x.Id).ToList();

            return data;
        }

        public int Save(Persona2 persona2)
        {
            if (persona2.Id <= 0)
            {
                persona2.UsuarioModifica = 1;
                persona2.FechaRegistro = DateTime.Now;

                _Personas2Context.Persona2.Add(persona2);
            }
            else
            {
                var model = GetById(persona2.Id);

                model.Activo = persona2.Activo;
                model.UsuarioModifica = persona2.UsuarioModifica;
                model.FechaModificado = persona2.FechaModificado;

                model.Nombres = persona2.Nombres;
                model.Apellidos = persona2.Apellidos;
                model.TipoDocumento = persona2.TipoDocumento;
                model.NoDocumento = persona2.NoDocumento;
                model.FechaNacimiento = persona2.FechaNacimiento;
                model.NoContacto = persona2.NoContacto;
                model.Email = persona2.Email;
                model.Direccion = persona2.Direccion;

                _Personas2Context.Persona2.Update(model);
            }

            _Personas2Context.SaveChanges();

            return persona2.Id;
        }

        public bool Delete(int id)
        {
            var model = GetById(id);

            model.Eliminado = !model.Eliminado;
            model.UsuarioElimina = 1;
            model.FechaEliminado = DateTime.Now;

            _Personas2Context.Persona2.Update(model);

            _Personas2Context.SaveChanges();

            return model.Eliminado;
        }
    }
}
