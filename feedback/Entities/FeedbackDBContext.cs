using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using feedback.Models;
using System.Data.Entity;

namespace feedback.Entities
{
    public class FeedbackDBContext : DbContext
    {
        public FeedbackDBContext() : base("feedbackDBEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new HttpUnhandledException();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Reaction> Reactions { get; set; }

    }
}