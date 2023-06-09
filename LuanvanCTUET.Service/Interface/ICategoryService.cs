using LuanvanCTUET.Service.ViewModel.Product;
using System.Collections.Generic;

namespace LuanvanCTUET.Service.Interface
{
    public interface ICategoryService
    {
        CategoryViewModel Add(CategoryViewModel categoryVM);
        void Update(CategoryViewModel categoryVM);
        void Delete(int id);
        List<CategoryViewModel> GetAll();
        List<CategoryViewModel> GetAll(string keyword);
        List<CategoryViewModel> GetAllByParentId(int parentId);
        CategoryViewModel GetById(int id);
        void UpdateParentId(int sourceId, int targetI, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);
        List<CategoryViewModel> GetHomeCategories(int top);
        void Save();
    }
}