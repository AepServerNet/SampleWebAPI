using SampleWebAPI.NET6.Models.Entities;

namespace SampleWebAPI.NET6.Models.Services.Application
{
    public interface IUserService : IRepository<Person, int>
    {
        //Eventuali metodi aggiuntivi diversi da quelli CRUD standard
    }
}
