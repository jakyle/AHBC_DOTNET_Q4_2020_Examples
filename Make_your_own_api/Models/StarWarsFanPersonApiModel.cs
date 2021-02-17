using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Make_your_own_api.Models
{
    public class StarWarsFanPersonApiModel
    {
        public string PeronalNotes { get; set; }
        public bool IsAFan { get; set; }
        public string[] Films { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }
        public string HomeWorld { get; set; }
        public string Mass { get; set; }
        public string Name { get; set; }
    }
}
