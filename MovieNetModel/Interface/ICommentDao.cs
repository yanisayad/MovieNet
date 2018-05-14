using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    interface ICommentDao
    {
        Comment CreateComment(Comment comment);
        Comment UpdateComment(Comment comment);
        bool DeleteMovie(Comment comment);
    }
}
