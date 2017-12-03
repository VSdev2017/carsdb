using System;
using Sport.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Context())
            {
                var temp = c.Manufacturers.ToList();
                foreach (var m in temp)
                {
                      Console.WriteLine("Manufacturer id = {0}, Name={1}, Country={2}", m.id,m.Name,m.Country);
                }
                Console.ReadKey();

            }
            
            
        }
    }
}
