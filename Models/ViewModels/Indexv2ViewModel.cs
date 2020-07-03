using System.Collections.Generic;

namespace yapf1.Models.ViewModels
{
    public class Indexv2ViewModel
    { 
        public IEnumerable<Longread> Posts { get; set; }
        
        public PageViewModel PageViewModel { get; set; }
    }
} 