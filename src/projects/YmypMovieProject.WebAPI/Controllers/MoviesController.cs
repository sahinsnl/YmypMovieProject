﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Entity.Dtos.Movies;

namespace YmypMovieProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        var movies = _movieService.GetAll();
        return Ok(movies);
    }
    [HttpGet("fullInfo")]
    public IActionResult GetFullInfo()
    {
        var movies = _movieService.GetMoviesWithFullInfo();
        return Ok(movies);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var movie = _movieService.GetById(id);
        return Ok(movie);
    }
    [HttpPost]
    public IActionResult Insert([FromBody] MovieAddRequestDto dto)
    {
        _movieService.Insert(dto);
        return StatusCode(201,dto);
    }
    [HttpPut]
    public IActionResult Update([FromBody] MovieUpdateRequestDto dto)
    {
        _movieService.Modify(dto);
        return Ok(dto);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _movieService.Remove(id);
        return Content("Movie deleted successfuly");
    }
}
