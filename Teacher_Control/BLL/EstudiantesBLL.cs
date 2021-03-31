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
    public class EstudiantesBLL
    {
        private ApplicationDbContext _contexto { get; set; }
        public EstudiantesBLL(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        public async Task<bool> Guardar(Estudiantes estudiante)
        {
            if (!await Existe(estudiante.EstudianteId))
                return await Insertar(estudiante);
            else
                return await Modificar(estudiante);

        }

        private async Task<bool> Existe(int id)
        {
            bool ok = false;

            try
            {
                ok = await _contexto.Estudiante.AnyAsync(e => e.EstudianteId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Insertar(Estudiantes estudiantes)
        {
            bool ok = false;
            try
            {
                await _contexto.AddAsync(estudiantes);
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Modificar(Estudiantes estudiantes)
        {
            bool ok = false;

            try
            {
                _contexto.Entry(estudiantes).State = EntityState.Modified;
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }


        public async Task<Estudiantes> Buscar(int id)
        {
            Estudiantes estudiantes;

            try
            {

                estudiantes = await _contexto.Estudiante.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

            return estudiantes;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool ok = false;
            try
            {
                var registro = await Buscar(id);
                if (registro != null)
                {
                    _contexto.Estudiante.Remove(registro);
                    ok = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<List<Estudiantes>> GetEstudiantes()
        {
            List<Estudiantes> lista = new List<Estudiantes>();

            try
            {
                lista = await _contexto.Estudiante.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        public async Task<List<Estudiantes>> Getlist(Expression<Func<Estudiantes, bool>> criterio)
        {
            List<Estudiantes> lista = new List<Estudiantes>();

            try
            {
                lista = await _contexto.Estudiante.Where(criterio).ToListAsync();
                lista.Sort((x, y) => x.Nombres.CompareTo(y.Nombres));

            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
}
