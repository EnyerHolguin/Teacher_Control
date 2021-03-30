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
    public class SemestresBLL
    {
        private ApplicationDbContext _contexto { get; set; }
        public SemestresBLL(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        public async Task<bool> Guardar(Semestres semestres)
        {
            if (!await Existe(semestres.SemestreId))
                return await Insertar(semestres);
            else
                return await Modificar(semestres);

        }

        private async Task<bool> Existe(int id)
        {
            bool ok = false;

            try
            {
                ok = await _contexto.Semestre.
                    AnyAsync(i => i.SemestreId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Insertar(Semestres semestres)
        {
            bool ok = false;
            try
            {
                await _contexto.AddAsync(semestres);
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Modificar(Semestres semestres)
        {
            bool ok = false;

            try
            {
                _contexto.Entry(semestres).State = EntityState.Modified;
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<Semestres> Buscar(int id)
        {
            Semestres semestres;

            try
            {

                semestres = await _contexto.Semestre.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

            return semestres;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool ok = false;
            try
            {
                var registro = await Buscar(id);
                if (registro != null)
                {
                    _contexto.Semestre.Remove(registro);
                    ok = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<List<Semestres>> Getsemestres()
        {
            List<Semestres> lista = new List<Semestres>();

            try
            {
                lista = await _contexto.Semestre.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        public async Task<List<Semestres>> Getlist(Expression<Func<Semestres, bool>> criterio)
        {
            List<Semestres> lista = new List<Semestres>();

            try
            {
                lista = await _contexto.Semestre.Where(criterio).ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

    }
}
