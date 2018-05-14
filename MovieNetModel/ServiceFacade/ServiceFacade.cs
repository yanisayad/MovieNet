using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;
using MovieNetModel.Factory;

namespace MovieNetModel.ServiceFacade
{
    class ServiceFacade : IServiceFacade
    {
        private IUserDao userDao       = null;
        private IMovieDao movieDao     = null;
        private ICommentDao commentDao = null;

        public ServiceFacade()
        {
            userDao    = DaoFactory.getFactory().getUserDao();
            movieDao   = DaoFactory.getFactory().getMovieDao();
            commentDao = DaoFactory.getFactory().getCommentDao();
        }

        public IUserDao getUserDao()
        {
            return userDao;
        }

        public IMovieDao getMovieDao()
        {
            return movieDao;
        }

        public ICommentDao getCommentDao()
        {
            return commentDao;
        }
    }
}
