using System.Collections.Generic;

namespace openwheels.Models.ViewModels
{
    public class Indexv2ViewModel
    {
        public IEnumerable<Longread> Posts { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}