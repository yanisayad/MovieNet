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
        //public abstract IUserDao getAllUsers();
        public abstract IUserDao getUserDao(DataModelContainer dataModel);

        public abstract IMovieDao getMovieDao(DataModelContainer dataModel);

        public abstract ICommentDao getCommentDao(DataModelContainer dataModel);

        public static AbstractDaoFactory getFactory()
        {
            return new DaoFactory();
        }

    }
}
