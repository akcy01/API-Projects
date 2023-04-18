using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAndBookStore.Entities
{
    
    public class MusicAlbum : Product
    {
        public string SingerName { get; set; }
        public int NumberOfSongs { get; set; }
    }
}
