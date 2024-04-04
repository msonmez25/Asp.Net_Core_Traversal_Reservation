using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommenttService : IGenericService<Commentt>
    {
        List<Commentt> TGetListCommentWithDestination();
        public List<Commentt> TGetListCommentWithUser();
        public List<Commentt> TGetListCommentWithDestinationAndUser(int id);
        public List<Commentt> TGetListCommentWithUser(int id);
        public List<Commentt> TGetListCommentWithDestination(int id);
    }
}
