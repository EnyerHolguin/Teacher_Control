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
    public class AdicionalesBLL
    {
        private ApplicationDbContext _contexto { get; set; }
        public AdicionalesBLL(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        public async Task<bool> Guardar(Adicionales adicionales)
        {
            if (!await Existe(adicionales.AdicionalesId))
                return await Insertar(adicionales);
            else
                return await Modificar(adicionales);

        }

        private async Task<bool> Existe(int id)
        {
            bool ok = false;

            try
            {
                ok = await _contexto.Adicionale.AnyAsync(e => e.AdicionalesId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Insertar(Adicionales adicionales)
        {
            bool ok = false;
            try
            {
                await _contexto.AddAsync(adicionales);
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        private async Task<bool> Modificar(Adicionales adicionales)
        {
            bool ok = false;

            try
            {
                _contexto.Entry(adicionales).State = EntityState.Modified;
                ok = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }


        public async Task<Adicionales> Buscar(int id)
        {
            Adicionales adicionales;

            try
            {
                adicionales = await _contexto.Adicionale.Where(i => i.AdicionalesId == id).AsNoTracking().SingleOrDefaultAsync();

                var aux = _contexto.Set<Adicionales>().Local.SingleOrDefault(h => h.AdicionalesId == id);
                if (aux != null)
                    _contexto.Entry(aux).State = EntityState.Detached;
            }
            catch (Exception)
            {

                throw;
            }

            return adicionales;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool ok = false;
            try
            {
                var registro = await Buscar(id);
                if (registro != null)
                {
                    _contexto.Adicionale.Remove(registro);
                    ok = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ok;
        }

        public async Task<List<Adicionales>> GetAdicionlaes()
        {
            List<Adicionales> lista = new List<Adicionales>();

            try
            {
                lista = await _contexto.Adicionale.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        public async Task<List<Adicionales>> Getlist(Expression<Func<Adicionales, bool>> criterio)
        {
            List<Adicionales> lista = new List<Adicionales>();

            try
            {
                lista = await _contexto.Adicionale.Where(criterio).ToListAsync();
               

            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

}
}
