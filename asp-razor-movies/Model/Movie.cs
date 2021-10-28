using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp_razor_movies.Models
{
    public enum Genres
    {
        Comedy, Drama, Horror, Romance
    }
    public class Movies
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres genre { get; set; }
        public decimal Price { get; set; }

    }
}
