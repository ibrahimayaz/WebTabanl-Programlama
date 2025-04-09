namespace OBS.Models
{
    public class Department
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Image { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
