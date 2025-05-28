using System.ComponentModel.DataAnnotations;

namespace DataAnnotationBEU.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
