﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
    }

}