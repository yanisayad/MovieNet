using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    public interface IServiceFacade
    {
        IUserDao getUserDao();

        IMovieDao getMovieDao();

        ICommentDao getCommentDao();
    }
}
