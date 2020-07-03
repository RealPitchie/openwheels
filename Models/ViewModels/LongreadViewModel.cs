using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace yapf1.Models.ViewModels
{
    public class LongreadViewModel
    {
        public Longread Longread { get; set; }
        public IFormFile[] Images { get; set; }
        public string[] Text { get; set; }
        public PageViewModel PageViewModel { get; set; }

        public LongreadViewModel()
        {
            
        }
    }
}