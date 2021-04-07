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
    public class AsistenciaBLL
    {
        private ApplicationDbContext contexto { get; set; }

        public AsistenciaBLL(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        //Metodo Existe.
        public async Task<bool> Existe(int id)
        {
            bool encontrado = false;
            try
            {
                encontrado = await contexto.Asistencia.AnyAsync(a => a.AsistenciaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return encontrado;
        }

        //Metodo Insertar.
        public async Task<bool> Insertar(Asistencia asistencia)
        {
            bool paso = false;
            try
            {
                await contexto.Asistencia.AddAsync(asistencia);
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }


        //Metodo Modificar.
        private async Task<bool> Modificar(Asistencia asistencia)
        {
            bool paso = false;
            try
            {
                contexto.Entry(asistencia).State = EntityState.Modified;
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        //Guardar
        public async Task<bool> Guardar(Asistencia asistencia)
        {
            if (!await Existe(asistencia.AsistenciaId))
                return await Insertar(asistencia);
            else
                return await Modificar(asistencia);
        }

        //Buscar
        public async Task<Asistencia> Buscar(int id)
        {
            Asistencia asistencia;
            try
            {
                asistencia = await contexto.Asistencia.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }

            return asistencia;
        }

        //Eliminar
        public async Task<bool> Eliminar(int id)
        {
            bool paso = false;
            try
            {
                var asistencia = await contexto.Asistencia.FindAsync(id);
                if (asistencia != null)
                {
                    contexto.Asistencia.Remove(asistencia);
                    paso = await contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        //GetList
        public async Task<List<Asistencia>> GetAsistencia()
        {
            List<Asistencia> lista = new List<Asistencia>();
            try
            {
                lista = await contexto.Asistencia.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

        public async Task<List<Asistencia>> GetList(Expression<Func<Asistencia, bool>> criterio)
        {
            List<Asistencia> lista = new List<Asistencia>();

            try
            {
                lista = await contexto.Asistencia.Where(criterio).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
}
