using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAndBookStore.Entities
{
 
    public class Movie : Product
    {
        public string DirectorName { get; set; }
        public double IMDBRate { get; set; }
    }
}
