using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Dao;
using MovieNetModel.Interface;

namespace MovieNetModel.Factory
{
    class DaoFactory : AbstractDaoFactory
    {
        public override IUserDao getUserDao()
        {
            return new UserDao();
        }

        public override IMovieDao getMovieDao()
        {
            return new MovieDao();
        }

        public override ICommentDao getCommentDao()
        {
            return new CommentDao();
        }
    }
}
