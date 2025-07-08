using AutoMapper;
using Core.Business.Utilites.Results;
using Core.Entity;
using FluentValidation;
using FluentValidation.Results;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Constants;
using YmypMovieProject.Business.Validators;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete
{
    public sealed class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly CategoryValidator _categoryValidator;
        private readonly CategoryUpdateValidator _updateValidator;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _updateValidator = new CategoryUpdateValidator();
            _categoryValidator = new CategoryValidator();

        }

        public IResult Insert(CategoryAddRequestDto dto)
        {
            try
            {
                ValidationResult result = _categoryValidator.Validate(dto);
                if (!result.IsValid)
                {
                    string errorMessages = string.Join(",\n ", result.Errors.Select(e => e.ErrorMessage));
                    return new ErrorResult(errorMessages);
                }
                //Eğer doğrulama başarılıysa, Category nesnesine dönüştürülür.
                var category = _mapper.Map<Category>(dto);
                _categoryRepository.Add(category);
                return new SuccessResult(ResultMessages.SuccessCategoryCreated);
            }
            catch (Exception e)
            {
                return new ErrorResult($"An error occurres while adding the category: {e.Message}");
            }

        }

        public IResult Modify(CategoryUpdateRequestDto dto)
        {
            try
            {
                ValidationResult result = _updateValidator.Validate(dto);
                if (!result.IsValid)
                {
                    string errorMessages = string.Join(",\n ", result.Errors.Select(e => e.ErrorMessage));
                    return new ErrorResult($"{ResultMessages.ErrorCategoryUpdated},\n\n{errorMessages}");
                }
                var category = _mapper.Map<Category>(dto);
                category.UpdateAt = DateTime.Now;
                _categoryRepository.Update(category);
                return new SuccessResult(ResultMessages.SuccessCategoryUpdated);
            }
            catch (Exception e)
            {

                return new ErrorResult($"An error occurres while adding the category: {e.Message}");
            }

            ////Gelen dto mapper ile category nesnesine dönüştürülür.
            //Category category = _mapper.Map<Category>(dto);
            ////Categori nesnesinin güncelleme tarihi ayarlanır.
            //category.UpdateAt = DateTime.Now;
            ////Category nesnesi veritabanına dataaccess metoduyla güncellenir.
            //_categoryRepository.Update(category);

        }

        public IResult Remove(Guid id)
        {
            try
            {
                var category = _categoryRepository.Get(c => c.Id.Equals(id));
                if (category is null)
                {
                    return new ErrorResult(ResultMessages.ErrorCategoryGetById);
                }
                category.IsDeleted = true;
                category.IsActive = false;
                category.UpdateAt = DateTime.Now;
                _categoryRepository.Update(category);
                return new SuccessResult(ResultMessages.SuccessCategoryDeleted);
            }
            catch (Exception e)
            {

                return new ErrorResult($"An error occurres while adding the category: {e.Message}");
            }

            //Category category = _categoryRepository.Get(c => c.Id.Equals(id));
            //if (category == null)
            //{
            //    throw new KeyNotFoundException($"Category with ID {id} not found");
            //}
            //category.IsDeleted = true;
            //category.IsActive = false;
            //category.UpdateAt = DateTime.Now;
            //_categoryRepository.Update(category);
        }
        public IDataResult<ICollection<CategoryResponseDto>> GetAll(bool deleted = false)
        {
            try
            {
                var categories = _categoryRepository.GetAll();
                if (categories == null || !categories.Any())
                {
                    return new ErrorDataResult<ICollection<CategoryResponseDto>>(ResultMessages.ErrorCategoryListed);
                }
                //Kategoriler CategoryResponseDto dönüştürülür.
                var categoriesDtos = _mapper.Map<ICollection<CategoryResponseDto>>(categories);
                return new SuccessDataResult<ICollection<CategoryResponseDto>>(categoriesDtos, ResultMessages.SuccessCategoryListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ICollection<CategoryResponseDto>>($"An error occurred while retrieving categories: {e.Message}");
            }

            ////Tüm kategoriler veritabanından alınır.
            //var categories = _categoryRepository.GetQuaryable().ToList();
            ////Kategoriler CategoryResponseDto dönüştürülür.
            //var categoriesDtos = _mapper.Map<List<CategoryResponseDto>>(categories);
            ////Kategoriler dto dönüştürüldükten sonra dto listesi döndürülür.
            //return categoriesDtos;
        }

        public IDataResult<CategoryResponseDto> GetById(Guid id)
        {

            try
            {
                var category = _categoryRepository.Get(c => c.Id.Equals(id));
                if (category == null)
                {
                    return new ErrorDataResult<CategoryResponseDto>(ResultMessages.ErrorCategoryGetById);
                }
                //Category nesnesi CategoryResponseDto dönüştürülür.
                var dto = _mapper.Map<CategoryResponseDto>(category);
                return new SuccessDataResult<CategoryResponseDto>(dto, ResultMessages.SuccessCategoryGetById);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<CategoryResponseDto>($"An error occurred while retrieving the category: {e.Message}");
            }
            //var category = _categoryRepository.Get(c => c.Id.Equals(id));
            //if (category == null)
            //{
            //    throw new KeyNotFoundException($"Category with ID {id} not found");
            //}
            //var categoryDto = _mapper.Map<CategoryResponseDto>(category);
            //return categoryDto;
        }

        public async Task InsertAsync(CategoryAddRequestDto dto)
        {

            //try
            //{
            //    if (dto is null)
            //    {
            //        throw new ArgumentNullException(nameof(dto), "CategoryAddRequestDto cannot be null");
            //    }
            //    // Gelen dto category mapper ile category nesnesine dönüştürülür.
            //    var category = _mapper.Map<Category>(dto);
            //    //await _categoryRepository.Add(category);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
        }

        public Task ModifyAsync(CategoryUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<CategoryResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
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
