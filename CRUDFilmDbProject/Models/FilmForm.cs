using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CRUDFilmDbProject.Models
{
    public class FilmForm

    {

        [Required]
        public string FilmTitle { get; set; }

        [Required]
        public string FilmCertificate { get; set; }

        [Key]
        public int FilmID { get; set; }

        public string FilmDescription { get; set; }

        public string FilmImage {  get; set;}
        public decimal FilmPrice { get; set; }

        public int Stars { get; set; }

        public DateTime ReleaseDate { get; set; }

    }

}