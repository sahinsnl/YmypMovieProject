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
    void Insert(TCreateDto dto);
    void Modify(TUpdateDto dto);
    void Remove(Guid id);
    ICollection<TResponseDto> GetAll();
    TResponseDto GetById(Guid id);
}
