using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Actors
{
    public sealed record ActorAddRequestDto(
        string FirstName,
        string Lastname,
        string? imageUrl,//IFormFile olarak değiştirilecek
        DateTime? BirthDate,
        string? Description) : ICreateDto;

}
