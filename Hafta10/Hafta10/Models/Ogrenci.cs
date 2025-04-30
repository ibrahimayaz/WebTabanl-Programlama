namespace Hafta10.Models
{
    public class Ogrenci
    {
        public long Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string BolumAdi { get; set; }

        public ICollection<Not> Notlar { get; set; }
    }
}
