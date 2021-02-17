using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Make_your_own_api.Models
{
    public class TodoApiModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsComplete { get; set; }
    }
}
