using System;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class FormModel
    {
        [Required]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Liczba powtórzeń")]
        [Range(1, 5, ErrorMessage = "Wartość musi być z przedziału [1, 5]")]
        public int Counter { get; set; }
    }
}
