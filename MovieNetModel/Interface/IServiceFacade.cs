using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    public class IServiceFacade
    {
        IUserDao getUserDao(User user)
        {
            throw new NotImplementedException();
        }

        IMovieDao getMovieDao(Movie movie)
        {
            throw new NotImplementedException();
        }

        ICommentDao ICommentDao(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
