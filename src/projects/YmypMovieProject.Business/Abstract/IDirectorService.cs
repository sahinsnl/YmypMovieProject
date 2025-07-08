using Core.Business;
using Core.Business.Utilites.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract;

public interface IDirectorService : 
    IGenericService<Director, DirectorResponseDto, DirectorAddRequestDto, DirectorUpdateRequestDto>, 
    IGenericServiceAsync<Director, DirectorResponseDto, DirectorAddRequestDto, DirectorUpdateRequestDto>
{
    IDataResult <List<DirectorDetailDto>> GetAllFullInfo();
    //List<Director> GetByFirstName(string firstName);
    //List<Director> GetByLastName(string lastName);
    //Director GetByFullName(string firstname, string lastname);

}
