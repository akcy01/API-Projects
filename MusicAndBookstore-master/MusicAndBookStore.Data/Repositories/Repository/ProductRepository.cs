using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Repositories.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        ApplicationDbContext _context;
        private readonly IMovieRepository _movieRepository;
        private readonly IMusicAlbumRepository _musicAlbumRepository;
        private readonly IBookRepository _bookRepository;

        public ProductRepository(ApplicationDbContext context, IMovieRepository movieRepository, IMusicAlbumRepository musicAlbumRepository, IBookRepository bookRepository) : base(context)
        {
            _context = context;
            _movieRepository = movieRepository;
            _musicAlbumRepository = musicAlbumRepository;
            _bookRepository = bookRepository;
        }

        public ArrayList GetAllProducts()
        {
            var books = _bookRepository.GetAll();
            var movies = _movieRepository.GetAll();
            var musicAlbums = _musicAlbumRepository.GetAll();

            ArrayList products = new ArrayList();
            products.Add(books);
            products.Add(movies);
            products.Add(musicAlbums);

            return products;
        }

        public int PurchaseProduct()
        {
            throw new NotImplementedException();
        }
    }
}
