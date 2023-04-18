using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;

namespace MusicAndBookStore.Entities
{
    public class Product 
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double BasePrice { get; set; }
    }
}
