using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAndBookStore.Entities
{
   
    public class Book : Product
    {
        public int ISBNNumber { get; set; }
        public string WriterName { get; set; }
    }
}
