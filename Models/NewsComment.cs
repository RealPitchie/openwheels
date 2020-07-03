using System;

namespace yapf1.Models
{
    public class NewsComment
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public bool AuthorShown { get; set; }
        public string Text { get; set; }
        public DateTime Posted { get; set; }
        public News News { get; set; }
        public string PostId { get; set; }
    }
}