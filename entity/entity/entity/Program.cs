
using entity.Entities;

namespace entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var us = new Users
                {
                    Name="Yaroslav",
                    Age=26,
                    City="Lviv",
                    University="LDFA",
                    Category=".Net"
                };
                db.user.Add(us);
                db.SaveChanges();
            }
        }
    }
}
 