using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Teacher_Control.Data;
using Teacher_Control.Models;

namespace Teacher_Control.BLL
{
    public class InscripcionBLL
    {
        private ApplicationDbContext _contexto { get; set; }
        public InscripcionBLL(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        public async Task<bool> Guardar(Inscripcion inscripcion)
        {
            if (!await Existe(inscripcion.IncripcionId))
                return await Insertar(inscripcion);
            else
                return await Modificar(inscripcion);

        }

        private async Task<bool> Existe(int id)
        {
            bool ok = false;

            try
            {
                ok = await _contexto.Inscripcions.AnyAsync(i => i.IncripcionId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Insertar(Inscripcion inscripcion)
        {
            bool ok = false;
            try
            {
                await _contexto.AddAsync(inscripcion);
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Modificar(Inscripcion inscripcion)
        {
            bool ok = false;

            try
            {
                _contexto.Entry(inscripcion).State = EntityState.Modified;
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<Inscripcion> Buscar(int id)
        {
            Inscripcion inscripcion;

            try
            {
                inscripcion = await _contexto.Inscripcions.Where(i => i.IncripcionId == id).AsNoTracking().SingleOrDefaultAsync();

                var aux = _contexto.Set<Inscripcion>().Local.SingleOrDefault(i => i.IncripcionId == id);
                if (aux != null)
                    _contexto.Entry(aux).State = EntityState.Detached;
            }
            catch (Exception)
            {

                throw;
            }

            return inscripcion;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool ok = false;
            try
            {
                var registro = await Buscar(id);
                if (registro != null)
                {
                    _contexto.Inscripcions.Remove(registro);
                    ok = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<List<Inscripcion>> GetInscripcion()
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            try
            {
                lista = await _contexto.Inscripcions.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }


        public async Task<List<Inscripcion>> GetList(Expression<Func<Inscripcion, bool>> criterio)
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            try
            {
                lista = await _contexto.Inscripcions.Where(criterio).ToListAsync();
               
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
}
