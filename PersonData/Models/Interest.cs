using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonData
{
    public class Interest
    {
        public long InterestId { get; set; }
        public long PersonId { get; set; }
        public string Name { get; set; }

        public virtual Person Person { get; set; }
    }
}
