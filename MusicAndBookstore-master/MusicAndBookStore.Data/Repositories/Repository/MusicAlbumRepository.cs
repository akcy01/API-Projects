using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Repositories.Repository
{
    public class MusicAlbumRepository : Repository<MusicAlbum>, IMusicAlbumRepository
    {
        ApplicationDbContext _context;
        public MusicAlbumRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
