using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;
using MovieNetModel.Factory;

namespace MovieNetModel.Service
{
    public sealed class ServiceFacade : IServiceFacade
    {
        private static readonly ServiceFacade instance = new ServiceFacade();
        private DataModelContainer dataModelContainer = new DataModelContainer();

        private IUserDao    userDao    = null;
        private IMovieDao   movieDao   = null;
        private ICommentDao commentDao = null;

        private ServiceFacade()
        {
            userDao = DaoFactory.getFactory().getUserDao(dataModelContainer);
            movieDao = DaoFactory.getFactory().getMovieDao(dataModelContainer);
            commentDao = DaoFactory.getFactory().getCommentDao();

        }

        public static ServiceFacade Instance
        {
            get
            {
                return instance;
            }
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
