using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Ocena jest wymagana.")]
        public int Rate { get; set; }
        public int BookId { get; set; }
        [Ignore]
        public virtual Book Book { get; set; }
    }
}
