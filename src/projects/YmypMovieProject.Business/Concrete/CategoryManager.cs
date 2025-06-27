using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete
{
    public sealed class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public void Insert(CategoryAddRequestDto dto)
        {
            //Gelen dto category mapper ile category nesnesine dönüştürülür.
            Category category = _mapper.Map<Category>(dto);
            //Category nesnesi veritabanına dataaccess metoduyla eklenir.
            _categoryRepository.Add(category);
        }

        public void Modify(CategoryUpdateRequestDto dto)
        {
            //Gelen dto mapper ile category nesnesine dönüştürülür.
            Category category = _mapper.Map<Category>(dto);
            //Categori nesnesinin güncelleme tarihi ayarlanır.
            category.UpdateAt = DateTime.Now;
            //Category nesnesi veritabanına dataaccess metoduyla güncellenir.
            _categoryRepository.Update(category);

        }

        public void Remove(Guid id)
        {
            Category category = _categoryRepository.Get(c => c.Id.Equals(id));
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {id} not found");
            }
            category.IsDeleted = true;
            category.IsActive = false;
            category.UpdateAt = DateTime.Now;
            _categoryRepository.Update(category);
        }
        public ICollection<CategoryResponseDto> GetAll()
        {
            //Tüm kategoriler veritabanından alınır.
            var categories = _categoryRepository.GetQuaryable().ToList();
            //Kategoriler CategoryResponseDto dönüştürülür.
            var categoriesDtos = _mapper.Map<List<CategoryResponseDto>>(categories);
            //Kategoriler dto dönüştürüldükten sonra dto listesi döndürülür.
            return categoriesDtos;
        }

        public CategoryResponseDto GetById(Guid id)
        {
            var category = _categoryRepository.Get(c => c.Id.Equals(id));
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {id} not found");
            }
            var categoryDto = _mapper.Map<CategoryResponseDto>(category);
            return categoryDto;
        }

        

        //    public List<Category> GetAll()
        //    {
        //        //_categoryRepository.GetQuaryable().ToList();
        //        //_categoryRepository.GetAll().ToList();
        //        return _categoryRepository.GetAll();
        //    }

        //    public Category GetById(Guid id)
        //    {
        //        return _categoryRepository.Get(c => c.Id == id);
        //    }

        //    public IQueryable<Category> GetQueryable()
        //    {
        //        return _categoryRepository.GetQuaryable();
        //    }

        //    public List<Category> GetByIsActive()
        //    {
        //        return _categoryRepository.GetAll(c => c.IsActive);
        //    }

        //    public List<Category> GetIsDeleted()
        //    {
        //        return _categoryRepository.GetAll(c => c.IsDeleted);
        //    }

        //    public void Insert(Category entity)
        //    {
        //        _categoryRepository.Add(entity);
        //    }

        //    public void Modify(Category entity)
        //    {
        //        entity.UpdateAt = DateTime.Now;
        //        _categoryRepository.Update(entity);
        //    }

        //    public void Remove(Category entity)
        //    {
        //        entity.IsDeleted = true;
        //        entity.IsActive = false;
        //        _categoryRepository.Delete(entity);
        //    }
        }
    }
