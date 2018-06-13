using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    public interface ICommentDao
    {
        Comment CreateComment(Comment comment);
        Comment UpdateComment(Comment comment);
        bool DeleteComment(Comment comment);
        List<Comment> GetAllComments();
        Comment GetComment(int comment_id);
    }
}
