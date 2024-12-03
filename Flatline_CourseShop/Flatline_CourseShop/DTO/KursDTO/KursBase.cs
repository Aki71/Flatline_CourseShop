using Flatline_CourseShop.Models;

namespace Flatline_CourseShop.DTO.KursDTO
{
    public class KursBase 
    {
        public string? NazivKursa { get; set; }
        public string? Opis { get; set; }
        public string? Slika { get; set; }
        public decimal Cena { get; set; }
        public Predavac? Autor { get; set; }
    }
}
