using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_intro.Models.ViewModels
{
    public class CharacterViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public IEnumerable<string> Abilities { get; set; }
        public string ImageUrl { get; set; }
    }
}
