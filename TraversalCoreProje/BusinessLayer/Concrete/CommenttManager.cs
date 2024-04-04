using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommenttManager : ICommenttService
    {
        ICommenttDal _commenttDal;

        public CommenttManager(ICommenttDal commenttDal)
        {
            _commenttDal = commenttDal;
        }

        public void TAdd(Commentt t)
        {
            _commenttDal.Insert(t);
        }

        public void TDelete(Commentt t)
        {
            _commenttDal.Delete(t);
        }

        public Commentt TGetByID(int id)
        {
            return _commenttDal.GetByID(id);
        }

        public List<Commentt> TGetList()
        {
            return _commenttDal.Getlist();
        }

        public List<Commentt> TGetDestinationById(int id)
        {
            return _commenttDal.GetListByFilter(x => x.DestinationID == id);
        }

        public void TUpdate(Commentt t)
        {
            _commenttDal.Update(t);
        }

        public List<Commentt> TGetListCommentWithDestination()
        {
            return _commenttDal.GetListCommentWithDestination();
        }

        public List<Commentt> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commenttDal.GetListCommentWithDestinationAndUser(id);
        }

        public List<Commentt> TGetListCommentWithUser(int id)
        {
            return _commenttDal.GetListCommentWithUser(id);
        }

        public List<Commentt> TGetListCommentWithDestination(int id)
        {
            return _commenttDal.GetListCommentWithDestination(id);
        }

        public List<Commentt> TGetListCommentWithUser()
        {
            return _commenttDal.GetListCommentWithUser();
        }
    }
}
