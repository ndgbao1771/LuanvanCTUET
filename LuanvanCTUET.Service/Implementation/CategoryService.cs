using AutoMapper;
using AutoMapper.QueryableExtensions;
using LuanvanCTUET.Data.Entity;
using LuanvanCTUET.Data.Enum;
using LuanvanCTUET.Data.IRepository;
using LuanvanCTUET.Infrastructure.Interface;
using LuanvanCTUET.Service.Interface;
using LuanvanCTUET.Service.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuanvanCTUET.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CategoryViewModel Add(CategoryViewModel categoryVM)
        {
            var cate = _mapper.Map<CategoryViewModel, Category>(categoryVM);
            _categoryRepository.Add(cate);
            return categoryVM;
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public List<CategoryViewModel> GetAll()
        {
            return _categoryRepository.FindAll().OrderBy(x => x.ParentId)
                .ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider).ToList();
        }

        public List<CategoryViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _categoryRepository.FindAll(x => x.Name.Contains(keyword) || x.Description.Contains(keyword))
                                          .OrderBy(x => x.ParentId).ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider)
                                          .ToList();
            else
                return _categoryRepository.FindAll().OrderBy(x => x.ParentId)
                                          .ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider)
                                          .ToList();
        }

        public List<CategoryViewModel> GetAllByParentId(int parentId)
        {
            return _categoryRepository.FindAll(x => x.Status == Status.Active && x.ParentId == parentId)
                                      .ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider)
                                      .ToList();
        }

        public CategoryViewModel GetById(int id)
        {
            return _mapper.Map<Category, CategoryViewModel>(_categoryRepository.FindById(id));
        }

        public List<CategoryViewModel> GetHomeCategories(int top)
        {
            var query = _categoryRepository.FindAll(x => x.HomeFlag == true, c => c.Products)
                                           .OrderBy(x => x.HomeOrder)
                                           .Take(top)
                                           .ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider);
            var categories = query.ToList();
            foreach(var category in categories)
            {
                
            }

            return categories;
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(CategoryViewModel categoryVM)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetI, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}