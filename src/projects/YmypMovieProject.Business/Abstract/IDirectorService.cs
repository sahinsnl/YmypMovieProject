using Core.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract;

public interface IDirectorService : IGenericService<Director, DirectorResponseDto,DirectorAddRequestDto,DirectorUpdateRequestDto>
{
    //List<Director> GetByFirstName(string firstName);
    //List<Director> GetByLastName(string lastName);
    //Director GetByFullName(string firstname, string lastname);
    //List<Director> GetAllFullInfo();
}
