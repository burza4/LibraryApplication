using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Autor jest wymagany.")]
        public string Author { get; set; }

        [Ignore]
        public virtual List<Review> Reviews { get; set; }
    }
}
