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
        public override IUserDao getUserDao(DataModelContainer dataModel)
        {
            return new UserDao(dataModel);
        }

        public override IMovieDao getMovieDao(DataModelContainer dataModel)
        {
            return new MovieDao(dataModel);
        }

        public override ICommentDao getCommentDao(DataModelContainer dataModel)
        {
            return new CommentDao(dataModel);
        }
    }
}
