using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;
using MovieNetModel.Factory;

namespace MovieNetModel.Factory
{
    abstract class AbstractDaoFactory
    {
        public abstract IUserDao getUserDao();

        public abstract IMovieDao getMovieDao();

        public abstract ICommentDao getCommentDao();

        public static AbstractDaoFactory getFactory()
        {
            return new DaoFactory();
        }
    }
}
