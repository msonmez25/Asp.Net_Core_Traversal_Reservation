using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommenttDal : IGenericDal<Commentt>
    {
        public List<Commentt> GetListCommentWithDestination();
        public List<Commentt> GetListCommentWithUser();
        public List<Commentt> GetListCommentWithDestinationAndUser(int id);
        public List<Commentt> GetListCommentWithUser(int id);
        public List<Commentt> GetListCommentWithDestination(int id);

    }
}
