using Bayanihand.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext dbc;
        public GenericRepository(AppDbContext dbc)
        {
            this.dbc = dbc;
        }

        public async Task<T> AddAsync(T entity)
        {
            await dbc.Set<T>().AddAsync(entity);
            await dbc.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            T? entity = await dbc.Set<T>().FindAsync(id);

            if(entity == null)
            {
                return;
            }

            dbc.Set<T>().Remove(entity);
            await dbc.SaveChangesAsync();

            return;
        }

        public async Task<bool> Exists(int? id)
        {
            T? entity = await dbc.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return false;
            }
            else return true;
        }

        public async Task<List<T>> GetAllAsync()
        {
            List<T> list = await dbc.Set<T>().ToListAsync();

            return list;
        }

        public async Task<T?> GetAsync(int? id)
        {
            return await dbc.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            dbc.Set<T>().Update(entity);
            await dbc.SaveChangesAsync();

            return;
        }

        public async Task<HandymanINV?> GetProfileByUserIdAsync(string userId)
        {
            return await dbc.HandymanINV
                .FirstOrDefaultAsync(h => h.UserId == userId);
        }
    }
}
