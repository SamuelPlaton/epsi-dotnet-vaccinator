using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatonsBDD_B31.Models
{
    public class Injection
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public DateTime date { get; set; }

        [MaxLength(50)]
        [Display(Name = "Marque")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public string brand { get; set; }

        [Display(Name = "Personne")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public virtual User user { get; set; }

        [Display(Name = "Vaccin")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public virtual Vaccine vaccine { get; set; }

    }
}
