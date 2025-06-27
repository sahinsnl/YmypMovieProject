using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Actors
{
    public sealed record ActorResponseDto
    (
        Guid id,
        string FirstName,
        string Lastname,
        string imageUrl,
        DateTime? BirthDate,
        string Description) : IResponseDto;
        
}
