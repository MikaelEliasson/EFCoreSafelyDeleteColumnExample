using System.Linq;

namespace EFCoreSafelyDeleteColumnExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var persons = db.Persons.ToList();
            }
        }
    }
}
