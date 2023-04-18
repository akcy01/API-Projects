using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Repositories.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
