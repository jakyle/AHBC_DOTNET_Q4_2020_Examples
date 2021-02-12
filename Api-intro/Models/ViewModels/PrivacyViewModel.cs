using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_intro.Models.ViewModels
{
    public class PrivacyViewModel
    {
        public IEnumerable<QuoteVM> Quotes { get; set; }
    }
}

