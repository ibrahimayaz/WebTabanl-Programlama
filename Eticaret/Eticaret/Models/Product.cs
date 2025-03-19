namespace Eticaret.Models
{
    public class Product
    {
        //PascalCase: Sınıf adları,  Özellikler, Metod
        //camelCase: değişkenler,  Metod
        public Product()
        {
            Id = new Guid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
