using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_intro.Models.ApiModels
{
    public class QuotesResponseModel
    {
        public int id { get; set; }
        public string quote { get; set; }
        public string by { get; set; }
        public string character { get; set; }
        public string image { get; set; }
    }
}
