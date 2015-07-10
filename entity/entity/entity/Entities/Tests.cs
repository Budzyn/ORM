using System.ComponentModel.DataAnnotations;
namespace entity.Entities
{
    public class Tests
    {
        [Key]
        public int TestID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ListAsk { get; set; }
        public int TimeMax { get; set; }
        public int Pass { get; set; }
        public DoTest DoTest { get; set; }
    }
}
