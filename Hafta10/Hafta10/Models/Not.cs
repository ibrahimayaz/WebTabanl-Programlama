using System.ComponentModel.DataAnnotations.Schema;

namespace Hafta10.Models
{
    public class Not
    {
        public int Id { get; set; }
        public double Puan { get; set; }

        [ForeignKey("Ogrenci")]
        public long OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
