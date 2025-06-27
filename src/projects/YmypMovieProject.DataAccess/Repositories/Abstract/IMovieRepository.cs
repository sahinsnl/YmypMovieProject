using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.DataAccess.Repositories.Abstract
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
