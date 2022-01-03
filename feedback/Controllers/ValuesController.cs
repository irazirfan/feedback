using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using feedback.Models;
using feedback.Entities;

namespace feedback.Controllers
{
    
    public class ValuesController : ApiController
    {
        private FeedbackDBContext _db = new FeedbackDBContext();

        // GET api/v1
        [Route("api/v1")]
        public IEnumerable<ApiViewModel> Get()
        {

            var feedbackList = from p in _db.Posts
                               join c in _db.Comments on p.postId equals c.postId
                               select new ApiViewModel
                               {
                                   PostDetails = p.postDetails,
                                   PosterName = p.userEmail,
                                   PostedAt = p.createdAt,
                                   CommentDetails = c.commentDetails,
                                   CommenterName = c.userEmail,
                                   CommenetedAt = c.createdAt,
                                   UpvoteCount = c.upvoteCount,
                                   DownvoteCount = c.downvoteCount
                               };


            return feedbackList;
        }

        /*private string GetUsername(string email)
        {
            var username = from u in _db.Users.Where(u => u.email == email) select u.name;
            return username.ToString();
        }*/

    }
}
