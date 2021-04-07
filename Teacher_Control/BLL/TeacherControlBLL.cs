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
    public class TeacherControlBLL
    {
        private ApplicationDbContext contexto { get; set; }

        public TeacherControlBLL(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        //Metodo Existe.
        public async Task<bool> Existe(int id)
        {
            bool encontrado = false;
            try
            {
                encontrado = await contexto.TeacherControl.AnyAsync(a => a.TeacherId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return encontrado;
        }

        //Metodo Insertar.
        public async Task<bool> Insertar(TeacherControl teache)
        {
            bool paso = false;
            try
            {
                await contexto.TeacherControl.AddAsync(teache);
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }


        //Metodo Modificar.
        private async Task<bool> Modificar(TeacherControl teache)
        {
            bool paso = false;
            try
            {
                contexto.Entry(teache).State = EntityState.Modified;
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        //Guardar
        public async Task<bool> Guardar(TeacherControl teache)
        {
            if (!await Existe(teache.TeacherId))
                return await Insertar(teache);
            else
                return await Modificar(teache);
        }

        //Buscar
        public async Task<TeacherControl> Buscar(int id)
        {
            TeacherControl teache;
            try
            {
                teache = await contexto.TeacherControl.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }

            return teache;
        }

        //Eliminar
        public async Task<bool> Eliminar(int id)
        {
            bool paso = false;
            try
            {
                var teache = await contexto.TeacherControl.FindAsync(id);
                if (teache != null)
                {
                    contexto.TeacherControl.Remove(teache);
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
        public async Task<List<TeacherControl>> GetTeacherControl()
        {
            List<TeacherControl> lista = new List<TeacherControl>();
            try
            {
                lista = await contexto.TeacherControl.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

        public async Task<List<TeacherControl>> GetList(Expression<Func<TeacherControl, bool>> criterio)
        {
            List<TeacherControl> lista = new List<TeacherControl>();

            try
            {
                lista = await contexto.TeacherControl.Where(criterio).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

    }


}

