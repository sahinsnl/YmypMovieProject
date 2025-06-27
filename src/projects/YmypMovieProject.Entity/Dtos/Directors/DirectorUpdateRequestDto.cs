using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Directors;

public sealed record DirectorUpdateRequestDto(
    Guid id,
    string FirstName,
    string Lastname,
    string imageUrl,
    DateTime BirthDate,
    string Description) : IUpdateDto;
