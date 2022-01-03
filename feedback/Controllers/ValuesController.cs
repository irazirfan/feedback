using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using feedback.Entities;

namespace feedback.Controllers
{
    
    public class ValuesController : ApiController
    {
        private FeedbackDBContext _db = new FeedbackDBContext();

        // GET api/v1
        [Route("api/v1")]
        public IEnumerable<ApiViewModel> GetAll()
        {
            var feedbackList = from p in _db.Posts
                               join c in _db.Comments on p.postId equals c.postId
                               join u in _db.Users on p.userEmail equals u.email
                               join us in _db.Users on c.userEmail equals us.email
                               select new ApiViewModel
                               {
                                   PostDetails = p.postDetails,
                                   PosterName = u.name,
                                   PostedAt = p.createdAt,
                                   CommentDetails = c.commentDetails,
                                   CommenterName = us.name,
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
