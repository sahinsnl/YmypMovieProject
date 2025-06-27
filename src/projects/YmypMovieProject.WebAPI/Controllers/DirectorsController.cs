using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DirectorsController : ControllerBase
{
    private readonly IDirectorService _directorService;
    private readonly IMapper _mapper;


    public DirectorsController(IDirectorService directorService, IMapper mapper)
    {
        _directorService = directorService;
        

    }
    //[httpget]
    //public ıactionresult getall()
    //{
    //    var director = _directorservice.getall();
    //    return ok(director);
    //}
    //[httpget("fullınfo")]
    //public ıactionresult getfullınfo()
    //{
    //    var directors = _directorservice.getallfullınfo();
    //    var dto = directors.select(d => new
    //    {
    //        ıd = d.ıd,
    //        adi = d.firstname,
    //        soyadi = d.lastname,
    //        resim = d.ımageurl,
    //        dogumtarihi = d.birthdate,
    //        aciklama = d.description,
    //        filmleri = d.movies.select(m => new
    //        {
    //            film = m.name,
    //            kategori = m.category.name,
    //            m.category.description
    //        }).tolist()
    //    }).tolist();
    //    return ok(dto);
    //}

    // [HttpGet("{id}")]
    //public IActionResult GetDirector(string id)
    //{
    //    //Director director = _directorService.GetById(Guid.Parse(id));
    //    //var dto = new
    //    //{
    //    //    director.Id,
    //    //    director.FirstName,
    //    //    director.LastName,
    //    //    director.ImageUrl,
    //    //    director.BirthDate,
    //    //    director.Description,
    //    //    Movies = director.Movies.Select(m => new
    //    //    {
    //    //        m.Name
    //    //    }).ToList()
    //    //};
    //    //return Ok(director);
    //}

    //[HttpGet("GetAllIsActive")]
    //public IActionResult GetAllIsActive()
    //{
    //    //var directors = _directorService.GetByIsActive();
    //    //return Ok(directors);

    //}
}
