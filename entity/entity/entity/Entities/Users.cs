using System.ComponentModel.DataAnnotations;
namespace entity.Entities
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string University { get; set; }
        public string Category { get; set; }
    }
}
