using System.Collections.Generic;

namespace Api_intro.Models.ViewModels
{
    public class EpisodesViewModel
    {
        public IEnumerable<EpisodeVM> Episodes { get; set; }
    }

    public class EpisodeVM
    {
        public string Name { get; set; }
        public string AirDate { get; set; }
        public IEnumerable<string>  Characters {get; set;}
        public string ImageUrl { get; set; }
    }

}