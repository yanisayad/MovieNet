using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;

namespace MovieNetModel.Dao
{
    public class CommentDao : ICommentDao
    {
        DataModelContainer dataModelContainer = new DataModelContainer();

        public Comment CreateComment(Comment comment)
        {
            dataModelContainer.Comments.Add(comment);
            dataModelContainer.SaveChanges();

            return comment;
        }

        public bool DeleteComment(Comment comment)
        {
            Comment delete_comment = dataModelContainer.Comments.Where(c => c.Id == comment.Id).FirstOrDefault();
            dataModelContainer.Comments.Remove(delete_comment);
            dataModelContainer.SaveChanges();

            return true;
        }

        public Comment UpdateComment(Comment comment)
        {
            Comment update_comment = dataModelContainer.Comments.Where(c => c.Id == comment.Id).FirstOrDefault();
            update_comment.Title = comment.Title;
            update_comment.Content = comment.Content;

            if (update_comment.Equals(comment))
                dataModelContainer.SaveChanges();
            else
                throw new Exception("Update failed");

            Console.WriteLine("The comment is update.");

            return update_comment;
        }

        public List<Comment> GetAllComments()
        {
            List<Comment> all_comments = dataModelContainer.Comments.ToList();

            return all_comments;
        }

        public Comment GetComment(int comment_id)
        {
            Comment comment = dataModelContainer.Comments.Where(c => c.Id == comment_id).FirstOrDefault();

            return comment;
        }
    }
}
