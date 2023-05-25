using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            //var entity = await context.Set<T>().FindAsync(id); - this does the same as GetAsync()
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }
        //here the Task performs an action but does not return a value, no return type <T> needed
        //Set<T>() this could say for example LeaveTypes. This makes the code generic. Find me the matching DB SET that has the type that came
        //in and then find the relevant records
        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //context.Entry(entity).State = EntityState.Modified; -- can be used instead of Update
            context.Update(entity); 
            await context.SaveChangesAsync();
        }
    }
}
