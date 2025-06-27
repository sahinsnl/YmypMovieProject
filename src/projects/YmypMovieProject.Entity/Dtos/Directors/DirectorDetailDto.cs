﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Directors
{
    public sealed record DirectorDetailDto(
    Guid id,
    string FirstName,
    string LastName,
    string ImageUrl,
    DateTime BirthDate,
    string Description) : IResponseDto;


}
