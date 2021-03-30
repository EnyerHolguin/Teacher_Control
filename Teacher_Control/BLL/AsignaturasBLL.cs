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
    public class AsignaturasBLL
    {
        private ApplicationDbContext _contexto { get; set; }
        public AsignaturasBLL(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        public async Task<bool> Guardar(Asignaturas asignatura)
        {
            if (!await Existe(asignatura.AsignaturaId))
                return await Insertar(asignatura);
            else
                return await Modificar(asignatura);
        }

        private async Task<bool> Existe(int id)
        {
            bool ok = false;

            try
            {
                ok = await _contexto.Asignatura.AnyAsync(a => a.AsignaturaId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Insertar(Asignaturas asignaturas)
        {
            bool ok = false;

            try
            {
                
                _contexto.Asignatura.Add(asignaturas);
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Modificar(Asignaturas asignaturas)
        {
            bool ok = false;
            try
            {
                _contexto.Entry(asignaturas).State = EntityState.Modified;
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<Asignaturas> Buscar(int id)
        {
            Asignaturas asignaturas;

            try
            {
                asignaturas = await _contexto.Asignatura.
                    Where(a => a.AsignaturaId == id).
                    AsNoTracking().
                    SingleOrDefaultAsync();

             
            }
            catch (Exception)
            {

                throw;
            }

            return asignaturas;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool ok = false;
            try
            {
                var registro = await Buscar(id);
                if (registro != null)
                {
                    _contexto.Asignatura.Remove(registro);
                    ok = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<List<Asignaturas>> GetAsignaturas()
        {
            List<Asignaturas> lista = new List<Asignaturas>();

            try
            {
                lista = await _contexto.Asignatura.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        public async Task<List<Asignaturas>> GetList(Expression<Func<Asignaturas, bool>> criterio)
        {
            List<Asignaturas> lista = new List<Asignaturas>();

            try
            {
                lista = await _contexto.Asignatura.Where(criterio).ToListAsync();
               
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
}
