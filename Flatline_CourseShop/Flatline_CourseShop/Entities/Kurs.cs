using System.ComponentModel.DataAnnotations;

namespace Flatline_CourseShop.Models
{
    public class Kurs
    {
        [Key]
        public Guid KursId { get; set; }
        public string? NazivKursa { get; set; }
        public string? Opis { get; set; }
        public string? Slika { get; set; }
        public decimal Cena { get; set; }
        public Predavac? Autor { get; set; }

        public int AutorId { get; set; }

    }
}
