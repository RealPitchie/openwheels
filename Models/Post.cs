using System;
using System.Collections.Generic;

namespace openwheels.Models
{
    public class Post
    {
        public string Id { get; set; }
        public DateTime Posted { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string ImageFile { get; set; }
        public string VideoLink { get; set; }
        public string Author { get; set; }
        public string AuthorAvatar { get; set; }
    }
}