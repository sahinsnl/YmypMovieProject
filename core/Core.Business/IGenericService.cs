using Core.Business.Utilites.Results;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business;

public interface IGenericService<TEntity,TResponseDto,TCreateDto,TUpdateDto> 
    where TEntity : class, IEntity, new()
    where TResponseDto : IResponseDto
    where TCreateDto : ICreateDto
    where TUpdateDto : IUpdateDto
{
    IResult Insert(TCreateDto dto);
    IResult Modify(TUpdateDto dto);
    IResult Remove(Guid id);
    IDataResult<ICollection<TResponseDto>> GetAll(bool deleted=false);
    IDataResult<TResponseDto> GetById(Guid id);
}
