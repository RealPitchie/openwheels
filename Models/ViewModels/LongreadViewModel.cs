using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace openwheels.Models.ViewModels
{
    public class LongreadViewModel
    {
        public Longread Longread { get; set; }
        public IFormFile[] Images { get; set; }
        public string[] Text { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}