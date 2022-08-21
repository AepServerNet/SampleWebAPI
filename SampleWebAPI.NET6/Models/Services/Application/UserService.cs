using Microsoft.EntityFrameworkCore;
using SampleWebAPI.NET6.Models.Entities;
using SampleWebAPI.NET6.Models.Services.Infrastructure;

namespace SampleWebAPI.NET6.Models.Services.Application
{
    public class UserService : IUserService
    {
        private readonly SampleWebApiDbContext dbContext;

        public UserService(SampleWebApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            try
            {
                return await dbContext.People.ToListAsync();
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }

        public Task<Person> GetByIdAsync(int id)
        {
            try
            {
                Person person = dbContext.People.Find(id);

                if (person == null)
                {
                    throw new ArgumentNullException();

                }

                dbContext.Entry(person).State = EntityState.Detached;
                return Task.FromResult(person);
            }
            catch
            {
                throw;
            }
        }

        public async Task InsertAsync(Person entity)
        {
            try
            {
                dbContext.People.Add(entity);
                await dbContext.SaveChangesAsync();

                dbContext.Entry(entity).State = EntityState.Detached;
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }

        public async Task UpdateAsync(Person entity)
        {
            try
            {
                Person person = dbContext.People.Find(entity.Id);

                if (person == null)
                {
                    throw new ArgumentNullException();
                }

                person.Cognome = entity.Cognome;
                person.Nome = entity.Nome;
                person.Email = entity.Email;
                person.Telefono = entity.Telefono;

                await dbContext.SaveChangesAsync();
                dbContext.Entry(person).State = EntityState.Detached;
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }

        public async Task DeleteAsync(int id)
        {
            Person user = dbContext.People.Find(id);

            if (user != null)
            {
                dbContext.People.Remove(user);
                await dbContext.SaveChangesAsync();

                dbContext.Entry(user).State = EntityState.Detached;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}