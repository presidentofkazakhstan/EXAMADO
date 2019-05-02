
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamADO.NET
{
   public class Country
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public int Population { get; set; }

        public virtual City City { get; set; }
    }
}