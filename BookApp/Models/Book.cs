using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class Book
    {
        [Display(Name = "Kitap Id")]
        public int BookId { get; set; }

        [Display(Name = "Kitap Adı")]
        [Required(ErrorMessage = "Kitap adı alanı boş olamaz!")]
        public string Title { get; set; } = null!;

        [Display(Name = "Kitap Özeti")]
        public string? Description { get; set; }

        [Display(Name = "Kitap Kapağı")]
        public string? Image { get; set; } = string.Empty;

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat alanı boş olamaz!")]
        public decimal Price { get; set; }


        public bool IsActive { get; set; }

        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Kategori alanı boş olamaz!")]
        public int CategoryId { get; set; }
    }
}