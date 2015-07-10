
using System.Data.Entity;


namespace entity.Entities
{
    public class Context:DbContext
    {
        public Context():base("MyDB")
        {

        }
        public DbSet<Users> user { get; set; }
        public DbSet<Tests> test { get; set; }
        public DbSet<Ask> ask { get; set; }
        public DbSet<DoTest> Testdo { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Lecture> lect { get; set; }
        public DbSet<Category> categ { get; set; }

        public string Name { get; set; }
    }
}
