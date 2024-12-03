using System.ComponentModel.DataAnnotations;

namespace Flatline_CourseShop.Models
{
    public class Ucenik
    {
        [Key]
        public Guid UcenikId { get; set; }
        public string ImeUcenika { get; set; }

        public Kurs? Kurs { get; set; }
        public int KursId { get; set; }
    }
}
