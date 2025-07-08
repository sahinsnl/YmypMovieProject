using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete
{

    public sealed class ActorManager //: IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IMapper _mapper;

        public ActorManager(IActorRepository actorRepository, IMapper mapper)
        {
            _actorRepository = actorRepository;
            _mapper = mapper;
        }

        public void Insert(ActorAddRequestDto dto)
        {
            Actor actor = _mapper.Map<Actor>(dto);
            _actorRepository.Add(actor);
        }

        public void Modify(ActorUpdateRequestDto dto)
        {
            Actor actor = _mapper.Map<Actor>(dto);
            actor.UpdateAt = DateTime.Now;
            _actorRepository.Update(actor);
        }

        public void Remove(Guid id)
        {
            Actor actor = _actorRepository.Get(a => a.Id == id);
            actor.IsActive = false;
            actor.IsDeleted = true;
            actor.UpdateAt = DateTime.Now;
            _actorRepository.Update(actor);
        }
        public ICollection<ActorResponseDto> GetAll()
        {
            var actors = _actorRepository.GetQuaryable().ToList();
            if (actors is null)
            {
                return new List<ActorResponseDto>();
            }
            List<ActorResponseDto> dtos = _mapper.Map<List<ActorResponseDto>>(actors);
            return dtos;
        }

        public ActorResponseDto GetById(Guid id)
        {
            var actor = _actorRepository.Get(a =>a.Id == id);
            if (actor is null)
            {
                throw new KeyNotFoundException("Actor not found");
            }
            ActorResponseDto dto = _mapper.Map<ActorResponseDto>(actor);
            return dto;
        }

        public Task InsertAsync(ActorAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(ActorUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ActorResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ActorResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }




        //private readonly IActorRepository _actorRepository;

        //public ActorManager(IActorRepository actorRepository)
        //{
        //    _actorRepository = actorRepository;
        //}

        //public List<Actor> GetAll()
        //{
        //    return _actorRepository.GetAll();
        //}
        //public List<Actor> GetAllByWithMovie()
        //{
        //    return _actorRepository.GetQuaryable().Include(a => a.Movies).ToList();
        //}
        //public List<Actor> GetByFirstName(string firstname)
        //{
        //    return _actorRepository.GetAll(a => a.FirstName == firstname);
        //}

        //public Actor GetByFullName(string firstname, string lastname)
        //{
        //    return _actorRepository.Get(a => a.FirstName == firstname && a.LastName == lastname);
        //}

        //public Actor GetById(Guid id)
        //{
        //    return _actorRepository.Get(a =>a.Id == id);
        //}
        //public List<Actor> GetByIsActive()
        //{
        //    return _actorRepository.GetAll(a => a.IsActive);
        //}

        //public List<Actor> GetIsDeleted()
        //{
        //    return _actorRepository.GetAll(a => a.IsDeleted);
        //}

        //public List<Actor> GetByLastName(string lastname)
        //{
        //   return _actorRepository.GetAll(a => a.LastName == lastname);
        //}
        //public IQueryable<Actor> GetQueryable()
        //{
        //    return _actorRepository.GetQuaryable();
        //}

        //public void Insert(Actor entity)
        //{
        //    _actorRepository.Add(entity);
        //}

        //public void Modify(Actor entity)
        //{
        //    _actorRepository.Update(entity);
        //}

        //public void Remove(Actor entity)
        //{
        //    _actorRepository.Delete(entity);
        //}

    }
}
