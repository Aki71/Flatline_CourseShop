using System.ComponentModel.DataAnnotations;

namespace Flatline_CourseShop.Models
{
    public class Kategorija
    {
        [Key]
        public Guid KategorijaId { get; set; }
        public string ImeKategoije { get; set; }

        public ICollection<Kurs>? Kursevi { get; set; }
    }
}
