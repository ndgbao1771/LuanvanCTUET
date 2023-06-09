using LuanvanCTUET.Data.Entity;
using LuanvanCTUET.Infrastructure.Interface;
using System.Collections.Generic;

namespace LuanvanCTUET.Data.IRepository
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        List<Category> GetByAlias(string alias);
    }
}