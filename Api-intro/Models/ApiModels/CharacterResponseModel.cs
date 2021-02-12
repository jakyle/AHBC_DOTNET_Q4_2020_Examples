using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_intro.Models.ApiModels
{
    public class CharacterResponseModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string hair { get; set; }
        public string[] alias { get; set; }
        public string origin { get; set; }
        public string[] abilities { get; set; }
        public string img_url { get; set; }
    }

}
