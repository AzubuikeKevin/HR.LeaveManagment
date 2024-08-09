using HR.LeaveManagement.Application.Persistence.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class GenericReposistory<T> : IGenericRepository<T> where T : class
    {
        private readonly LeaveManagementDbContext _dbcontext;
        public GenericReposistory(LeaveManagementDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            await _dbcontext.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbcontext.Set<T>().Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }

        public async Task<T> Get(int id)
        {
            return await _dbcontext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
        }
    }
}
