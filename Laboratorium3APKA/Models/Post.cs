using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___Post_App.Models
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz wpisać zawartość")]
        [StringLength(maximumLength: 200, ErrorMessage = "Za dużo znaków!")]
        [Display(Name = "Aparat")]
        public string Content {  get; set; }
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Musisz wpisać Autora!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za dużo znaków!")]
        public string Author { get; set; }
        [Display(Name = "Data i godzina")]
        [Required(ErrorMessage = "Musisz uzupełnić datę!")]
        public DateTime Date { get; set; }
        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Musisz wpisać opis!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Za dużo znaków!")]
        public string Tags { get; set; }
        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Musisz wpisać dane!")]
        [StringLength(maximumLength: 200, ErrorMessage = "Za dużo znaków!")]
        public string Comment { get; set; }
        [Display(Name = "Rozdzielczość")]
        public string Format { get; set; }
        [Display(Name = "Format")]

        public DateTime Created { get; set; }

    }
}
