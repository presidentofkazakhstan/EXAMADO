using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
    public class City
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public int Population { get; set; }

        public  Street Street { get; set; }

        public virtual ICollection<Country> Countries  { get; set; }
    }
}
