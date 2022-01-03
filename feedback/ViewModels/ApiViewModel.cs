using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace feedback.Entities
{
    public class ApiViewModel
    {
        public string PostDetails { get; set; }
        public string PosterName { get; set; }
        public DateTime PostedAt { get; set; }
        public int CommentCount { get; set; }
        public string CommentDetails { get; set; }
        public string CommenterName { get; set; }
        public DateTime CommenetedAt { get; set; }
        public int UpvoteCount { get; set; }
        public int DownvoteCount { get; set; }
    }
}