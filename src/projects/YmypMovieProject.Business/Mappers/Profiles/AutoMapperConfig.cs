using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Dtos.Movies;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Mappers.Profiles;

public sealed class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        //Mapping Configuration for Category entity and DTOs
        CreateMap<Category, CategoryResponseDto>();
        CreateMap<CategoryAddRequestDto, Category>();
        CreateMap<CategoryUpdateRequestDto, Category>();

        //Mapping Configuration for Director entity and DTOs
        CreateMap<Director, DirectorResponseDto>();
        CreateMap<DirectorAddRequestDto, Director>();
        CreateMap<DirectorUpdateRequestDto, Director>();

        //Mapping configuration for Movie entity and DTOs
        CreateMap<Movie, MovieResponseDto>();
        CreateMap<MovieAddRequestDto, Movie>();
        CreateMap<MovieUpdateRequestDto, Movie>();
        CreateMap<Movie, MovieDetailDto>().ForMember(m => m.Players, option =>
        option.MapFrom(m => m.Actors.Select(a => $"{a.FirstName} {a.LastName}").ToHashSet()));

        //Mapping configuration for Actor entity and DTOs
        CreateMap<Actor,ActorResponseDto>();
        CreateMap<ActorAddRequestDto, Actor>();
        CreateMap<ActorUpdateRequestDto, Actor>();
    }
}
