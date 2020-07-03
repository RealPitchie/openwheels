using System;

namespace yapf1.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public bool AuthorShown { get; set; }
        public string Text { get; set; }
        public DateTime Posted { get; set; }
         
        public string LongreadId { get; set; }
        public string PostId { get; set; }
        public string ImageFile { get; set; } 
        public string VideoLink { get; set; }
        public string MobileImage { get; set; }
        public string AuthorAvatar { get; set; } 
    }
}