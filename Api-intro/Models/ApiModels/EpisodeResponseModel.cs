using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_intro.Models.ApiModels
{
    public class EpisodeResponseModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string director { get; set; }
        public string writer { get; set; }
        public string[] characters { get; set; }
        public string img_url { get; set; }
    }
}

