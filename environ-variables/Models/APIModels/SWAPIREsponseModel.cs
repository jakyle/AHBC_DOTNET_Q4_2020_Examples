﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace environ_variables.Models.APIModels
{


    public class PersonResponseModel
    {
        public string birth_year { get; set; }
        public string eye_color { get; set; }
        public string[] films { get; set; }
        public string gender { get; set; }
        public string hair_color { get; set; }
        public string height { get; set; }
        public string homeworld { get; set; }
        public string mass { get; set; }
        public string name { get; set; }
        public string skin_color { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string[] species { get; set; }
        public string[] starships { get; set; }
        public string url { get; set; }
        public string[] vehicles { get; set; }
    }


}

