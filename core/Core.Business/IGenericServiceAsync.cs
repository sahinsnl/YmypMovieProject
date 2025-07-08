using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business;

public interface IGenericServiceAsync<TEntity, TResponseDto, TCreateDto, TUpdateDto>
    where TEntity : class, IEntity, new()
    where TResponseDto : IResponseDto
    where TCreateDto : ICreateDto
    where TUpdateDto : IUpdateDto
{
    Task InsertAsync(TCreateDto dto);
    Task ModifyAsync(TUpdateDto dto);
    Task RemoveAsync(Guid id);
    Task<ICollection<TResponseDto>> GetAllAsync();
    Task<TResponseDto> GetByIdAsync(Guid id);
}
