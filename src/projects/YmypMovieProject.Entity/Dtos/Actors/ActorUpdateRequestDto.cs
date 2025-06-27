using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Actors
{
    public sealed record ActorUpdateRequestDto(
        Guid id,
        string FirstName,
        string Lastname,
        string? imageUrl,
        DateTime? BirthDate,
        string? Description,
        bool IsActive = true,
        bool IsDeleted = false) : IUpdateDto;

}
