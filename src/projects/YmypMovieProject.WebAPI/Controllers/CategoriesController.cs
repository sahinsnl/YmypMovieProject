using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Mappers.Categories;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _categoryService.GetAll();

        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
        //var categories = _categoryService.GetAll();
        //return Ok(categories);
    }

    [HttpGet("id")]
    public IActionResult GetById(Guid id)
    {
        var result = _categoryService.GetById(id);
        if (!result.Success)
        {
            return NotFound(result.Message);
        }
        return Ok(result.Data);
        //var category = _categoryService.GetById(id);
        //return Ok(category);
    }

    [HttpPost]
    public IActionResult Create(CategoryAddRequestDto category)
    {
        var result = _categoryService.Insert(category);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
    }

    [HttpPut]
    public IActionResult Update(CategoryUpdateRequestDto category)
    {
        var result = _categoryService.Modify(category);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
        //_categoryService.Modify(category);
        //return Content("Kategori güncelleme işlemi başarılı...");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var result = _categoryService.Remove(id);
        if (!result.Success)
        {
            return NotFound(result.Message);
        }
        return Ok(result.Message);
        //_categoryService.Remove(id);
        //return Content("Kategori silme işlemi başarılı...");
    }

    //[HttpGet("active")]
    //public IActionResult Active()
    //{
    //    var IsActiveCategories = _categoryService.GetByIsActive();
    //    return Ok(IsActiveCategories);
    //}

    //[HttpGet("delete")]
    //public IActionResult IsDeleted()
    //{
    //    var IsDeletedCategories = _categoryService.GetIsDeleted();
    //    return Ok(IsDeletedCategories);
    //}

    //[HttpGet("GetAllFullInfo")]
    //public IActionResult GetAllFullInfo()
    //{
    //    var categories = _categoryService.GetQueryable().Include(c => c.Movies).ToList();
    //    var dto = _mapper.ConvertToResponseList(categories);
    //    return Ok(dto);
    //}
}
