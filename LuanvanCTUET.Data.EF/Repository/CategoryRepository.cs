using LuanvanCTUET.Data.Entity;
using LuanvanCTUET.Data.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace LuanvanCTUET.Data.EF.Repository
{
    public class CategoryRepository : EFRepository<Category, int>, ICategoryRepository
    {
        private AppDbContext _context;

        public CategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Category> GetByAlias(string alias)
        {
            return _context.Categories.Where(x => x.SeoAlias == alias).ToList();
        }
    }
}