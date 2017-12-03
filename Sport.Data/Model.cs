using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Data
{
    public class Model
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Manufacturer manufacturer { get; set; }
    }
}
