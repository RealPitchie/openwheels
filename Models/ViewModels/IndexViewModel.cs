using System.Collections.Generic;
using yapf1.Models;

namespace yapf1.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        
        public PageViewModel PageViewModel { get; set; }
    }
}